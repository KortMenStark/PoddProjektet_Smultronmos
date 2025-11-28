using BL;
using DAL;
using DAL.Repository;
using Models_new;
using PL.Validering;
using System.Drawing;
using System.ServiceModel.Syndication;
using System.Linq;
using System.Drawing.Drawing2D;
using static System.Net.WebRequestMethods;

namespace PL

{
    public partial class Mainform : Form
    {
        //Detta implementerar gränssnittet för IRssService
        private readonly IRssService enRssService;

        //H�ller reda pÅ det hämtade RSS-flödet och lagrar det i hamtatfeed = feed;
        private SyndicationFeed? hamtatfeed;

        //Detta hanterar poddrelaterade operationer.
        private readonly PoddService enPoddService;

        //Detta hanterar kategorirelaterade operationer
        private readonly KategoriService enKategoriService;

        //Lokal lista för alla kategorier som laddas in i comboboxen (dropdownmenyn med kategorier)
        private List<Kategori> allaKategorier = new();

        //Lokal lista för alla poddar som laddas in i listboxen
        private List<Podd> allaPoddar = new List<Podd>();

        // Håller reda på vilken kategori podden hade när den valdes
        private string? _valdPoddUrsprungligKategoriId;

        // Håller reda på vilken RSS-URL som användes när flödet hämtades
        private string? senastHamtdRssUrl;

        // Används för att ignorera SelectedIndexChanged-event tillfälligt
        private bool _ignoreKategoriEvents = false;

        public Mainform()
        {
            InitializeComponent();
            enRssService = new RssService();
            enPoddService = new PoddService(new PoddRepository(new MongoDbContext()));
            pbPoddBild.Visible = false;

            // Hanterar kategori-relaterade databasoperationer
            enKategoriService = new KategoriService(
            new KategoriRepository(new MongoDbContext()),
            new PoddRepository(new MongoDbContext()));
        }

        private void NollstallPoddBild()
        {
            pbPoddBild.Visible = false;
            pbPoddBild.Image = null;
        }
        private void VisaPoddBild(SyndicationFeed? feed)
        {
            NollstallPoddBild();

            if (feed == null)
                return;
            var bildUrl = feed.ImageUrl?.ToString();

            if (string.IsNullOrWhiteSpace(bildUrl))
                return;
            try
            {
                pbPoddBild.SizeMode = PictureBoxSizeMode.Zoom;
                pbPoddBild.LoadAsync(bildUrl);
                pbPoddBild.Visible = true;
            }

            catch
            {
                NollstallPoddBild();
            }
        }
        private void GaTillRSSLage()
        {
            btnSparaPodd.Visible = true;
            btnAvprenumerera.Visible = false;
            lblAktuellkategori.Visible = false;
            cmbPoddKategori.Visible = false;
            btnSparaPoddKategori.Visible = false;
            btnLaggTillNyKategori.Visible = false;
            lblAvsnittSeparator.Visible = false;

        }
        private void GaTillSparadPoddLage()
        {
            btnSparaPodd.Visible = false;
            btnAvprenumerera.Visible = true;
            lblAktuellkategori.Visible = true;
            cmbPoddKategori.Visible = true;
            btnLaggTillNyKategori.Visible = true;
            lblAvsnittSeparator.Visible = true;

            // Visa inte knappen förrän en ändring görs
            btnSparaPoddKategori.Visible = false;
        }

        //Synkroniserar UI med databasen varje gång kategorier ändras.
        private async Task LaddaKategorierAsync()
        {
            allaKategorier = await enKategoriService.HamtaAllaKategorier();
        }
        private async Task LaddaPoddarAsync()
        {
            allaPoddar = await enPoddService.HamtaAllaPoddar();
            VisaPoddar(allaPoddar);
            FyllFilterKategorier();
        }
        private async void btnHamtaRss_ClickAsync(object sender, EventArgs e)
        {
            var url = txtRssUrl.Text.Trim();

            // 1. Validera RSS-url via valideringsklassen
            if (!Validering.Validering.KontrolleraRssUrl(url, out string felmeddelande))
            {
                MessageBox.Show(felmeddelande);
                return;
            }
            try
            {
                // 2. Hämta flödet
                var feed = await enRssService.HamtaFlodeAsync(url);

                // 3. Spara RSS-flödet och URL:en som användes
                hamtatfeed = feed;
                senastHamtdRssUrl = url;

                // 4. Uppdatera GUI (EXAKT som din gamla version)
                GaTillRSSLage();
                txtTitel.Text = feed.Title.Text;

                lstAvsnitt.Items.Clear();
                foreach (var item in feed.Items)
                {
                    lstAvsnitt.Items.Add(item.Title.Text);
                }
                // Inget avsnitt väljs och listan rensas från tidigare valt avsnitt
                lstAvsnitt.ClearSelected();
                txtAvsnittTitel.Text = "";
                txtPubliceringsdatum.Text = "";
                txtBeskrivning.Text = "";

                VisaPoddBild(feed);

                // MessageBox.Show("RSS-flödet hämtades utan problem."); //Ett pop-up för att bekräfta lyckad hämtning
            }
            catch (Exception ettFel)
            {
                hamtatfeed = null;
                senastHamtdRssUrl = null;
                btnSparaPodd.Enabled = false;
                NollstallPoddBild();

                MessageBox.Show(ettFel.Message);
            }
        }
        private void lstAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAvsnitt.SelectedIndex < 0)
                return;

            var valtAvsnitt = hamtatfeed.Items.ElementAt(lstAvsnitt.SelectedIndex);

            txtAvsnittTitel.Text = valtAvsnitt.Title?.Text ?? "Ingen titel";

            txtPubliceringsdatum.Text = valtAvsnitt.PublishDate.DateTime
                .ToString("yyyy-MM-dd HH:mm");

            string renSammanfattning;

            // Om det INTE finns någon summary: använd din egen text
            if (valtAvsnitt.Summary == null || string.IsNullOrWhiteSpace(valtAvsnitt.Summary.Text))
            {
                renSammanfattning = "Ingen sammanfattning tillgänglig för detta avsnitt.";
            }
            else
            {
                // Finns summary: ta bort HTML
                renSammanfattning = TaBortHtml(valtAvsnitt.Summary.Text);
            }

            txtBeskrivning.Text = renSammanfattning;
        }
        private string TaBortHtml(string htmlText)
        {
            if (string.IsNullOrWhiteSpace(htmlText))
                return "";

            string utanHtml = System.Text.RegularExpressions.Regex.Replace(htmlText, "<.*?>", "");
            utanHtml = utanHtml.Replace("&nbsp;", " ");

            int startIndex = utanHtml.IndexOf("Hosted on Acast", StringComparison.OrdinalIgnoreCase);

            if (startIndex >= 0)
                utanHtml = utanHtml.Substring(0, startIndex);
            return utanHtml.Trim();
        }

        private async void btnSparaPodd_Click(object sender, EventArgs e)
        {
            var aktuellUrl = txtRssUrl.Text.Trim();

            // 1: Validera RSS-länken (tom + format)
            if (!Validering.Validering.KontrolleraRssUrl(aktuellUrl, out string fel))
            {
                MessageBox.Show(fel);
                return;
            }

            // 2: Kolla att vi faktiskt har ett hämtat flöde
            if (!Validering.Validering.KontrolleraAttFlodeFinns(hamtatfeed, out fel))
            {
                MessageBox.Show(fel);
                return;
            }

            // 3: Kolla att URL:en inte ändrats efter hämtning
            if (!Validering.Validering.KontrolleraAttRssInteAndrats(aktuellUrl, senastHamtdRssUrl, out fel))
            {
                MessageBox.Show(fel);
                return;
            }
            // 4: Öppna dialogen för att sätta namn/kategori
            var dlg = new SavePoddForm(
            hamtatfeed,
            allaKategorier,
            aktuellUrl, // använd den trimmade URL:en
            enPoddService,
            enKategoriService);


            // 5: Visa dialogen och vänta på resultatet
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Här vet vi att podden har sparats (SavePoddForm sätter OK bara om sparad == true)


                // 5.1 Ladda om alla poddar från databasen
                await LaddaPoddarAsync();


                // 5.2 Försök hitta den podd som har samma RSS-url som vi nyss sparade
                var nyPodd = allaPoddar
                .FirstOrDefault(p => string.Equals(p.RssUrl, aktuellUrl, StringComparison.OrdinalIgnoreCase));


                if (nyPodd != null)
                {
                    // 5.3 Välj podden i listan (triggar lstPoddar_SelectedIndexChangedAsync)
                    lstPoddar.SelectedItem = nyPodd;
                }
                else
                {
                    // (Valfritt) fallback: om vi inte hittar den, gör åtminstone en reload av listan
                    // och låt användaren välja själv.
                    MessageBox.Show("Podden sparades, men kunde inte hittas automatiskt i listan.");
                }
            }
        }
        private void VisaPoddar(IEnumerable<Podd> poddar)
        {
            lstPoddar.Items.Clear();

            // Sortera poddarna alfabetiskt på Titel
            var sorterade = poddar
                .OrderBy(p => p.Titel, StringComparer.CurrentCultureIgnoreCase)
                .ToList();

            foreach (var podd in sorterade)
            {
                lstPoddar.Items.Add(podd);
            }
        }
        private void FyllFilterKategorier()
        {
            if (allaPoddar == null || allaPoddar.Count == 0)
                return;

            // vilka kategori-Id:n används av poddarna?
            var användaKategoriIds = allaPoddar
                .Select(p => p.KategoriId)
                .Where(id => !string.IsNullOrWhiteSpace(id))
                .Distinct()
                .ToList();

            // ta fram de Kategori-objekt som matchar
            var kategorierSomHarPoddar = allaKategorier
                .Where(k => användaKategoriIds.Contains(k.Id))
                .OrderBy(k => k.Namn)
                .ToList();

            // koppla bort event tillfälligt så vi inte triggar filtrering mitt i uppdateringen
            cbmFilterKategori.SelectedIndexChanged -= cbmFilterKategori_SelectedIndexChanged;

            cbmFilterKategori.Items.Clear();
            cbmFilterKategori.Items.Add("Alla kategorier"); // special-värde

            foreach (var kat in kategorierSomHarPoddar)
            {
                cbmFilterKategori.Items.Add(kat);
            }

            cbmFilterKategori.DisplayMember = "Namn";
            cbmFilterKategori.ValueMember = "Id";
            cbmFilterKategori.SelectedIndex = 0;

            // koppla på event igen
            cbmFilterKategori.SelectedIndexChanged += cbmFilterKategori_SelectedIndexChanged;
        }
        private void FyllPoddKategoriDropdown()
        {
            if (cmbPoddKategori == null)
                return;
            cmbPoddKategori.Items.Clear();

            // Första posten representerar "ingen kategori"
            cmbPoddKategori.Items.Add("Ingen kategori");
            foreach (var kat in allaKategorier)
            {
                cmbPoddKategori.Items.Add(kat);
            }
            cmbPoddKategori.DisplayMember = "Namn";
        }
        private async void lstPoddar_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            if (lstPoddar.SelectedItem == null)
                return;

            GaTillSparadPoddLage();

            var valdPodd = (Podd)lstPoddar.SelectedItem;

            txtTitel.Text = valdPodd.Titel;

            _valdPoddUrsprungligKategoriId = valdPodd.KategoriId;

            FyllPoddKategoriDropdown();

            object itemToSelect = "Ingen kategori";

            if (!string.IsNullOrWhiteSpace(valdPodd.KategoriId))
            {
                foreach (var item in cmbPoddKategori.Items)
                {
                    if (item is Kategori k &&
                        string.Equals(k.Id, valdPodd.KategoriId, StringComparison.OrdinalIgnoreCase))
                    {
                        itemToSelect = item;
                        break;
                    }
                }
            }
            cmbPoddKategori.SelectedItem = itemToSelect;

            btnSparaPoddKategori.Visible = false;

            var feed = await enRssService.HamtaFlodeAsync(valdPodd.RssUrl);
            hamtatfeed = feed;

            lstAvsnitt.Items.Clear();

            foreach (var item in feed.Items)
                lstAvsnitt.Items.Add(item.Title.Text);

            VisaPoddBild(feed);

            //  Väljer första avsnittet automatiskt
            if (lstAvsnitt.Items.Count > 0)
            {
                lstAvsnitt.SelectedIndex = 0;   // Triggar lstAvsnitt_SelectedIndexChanged
            }
        }
        private async void Mainform_Load(object sender, EventArgs e)
        {
            btnSparaPodd.Visible = false;
            btnAvprenumerera.Visible = false;

            // 1. Ladda alla sparade poddar & kategorier från databasen
            await LaddaKategorierAsync();
            await LaddaPoddarAsync();


            // 2. Om det finns poddar – välj första
            if (lstPoddar.Items.Count > 0)
            {
                lstPoddar.SelectedIndex = 0;   // Triggar lstPoddar_SelectedIndexChangedAsync
            }
        }
        private void cbmFilterKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Om vi inte har några poddar laddade: gör inget
            if (allaPoddar == null || allaPoddar.Count == 0)
                return;

            var valt = cbmFilterKategori.SelectedItem;

            // Om inget valt -> visa alla
            if (valt == null)
            {
                VisaPoddar(allaPoddar);
                return;
            }

            // Om det är "Alla kategorier" (string-post i comboboxen)
            if (valt is string s)
            {
                if (string.Equals(s.Trim(), "Alla kategorier", StringComparison.OrdinalIgnoreCase))
                {
                    VisaPoddar(allaPoddar);
                }

                return;
            }

            // Om det är ett Kategori-objekt -> filtrera på dess Id
            // Kategori-objekt -> filtrera på dess Id
            if (valt is Kategori kat)
            {
                var filtrerade = allaPoddar
                    .Where(p => string.Equals(p.KategoriId, kat.Id, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                VisaPoddar(filtrerade);
            }
        }
        private async void btnAvprenumerera_ClickAsync(object sender, EventArgs e)
        {
            {
                var valdPodd = lstPoddar.SelectedItem as Podd;

                // Om ingen podd är vald, gör ingenting
                if (valdPodd == null)
                    return;

                var result = MessageBox.Show(
                    $"Vill du ta bort '{valdPodd.Titel}'?",
                    "Bekräfta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    await enPoddService.TaBortPodd(valdPodd.Id);
                    await LaddaPoddarAsync();
                }

            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            // Visa menyn när man klickar på knappen
            contextMenuStripPoddOptions.Show(btnOptions, new Point(btnOptions.Width, 0));

        }

        private void cmbPoddKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0. Ignorera event när vi uppdaterar dropdownen programmässigt
            if (_ignoreKategoriEvents)
                return;
            // 1. Ingen podd vald → gör ingenting (men pilla inte på knappen)
            if (lstPoddar.SelectedItem is not Podd valdPodd)
                return;
            // 2. Ta reda på vilken kategori-id som motsvarar valet i dropdownen
            string? valdKategoriId = null;
            if (cmbPoddKategori.SelectedItem is Kategori kat)
            {
                valdKategoriId = kat.Id;
            }
            else
            {
                // "Ingen kategori"-alternativet
                valdKategoriId = null;
            }
            // 3. Jämför med ursprungliga kategori-id
            if (string.Equals(valdKategoriId, _valdPoddUrsprungligKategoriId,
            StringComparison.OrdinalIgnoreCase))
            {
                // Ingen skillnad → ingen anledning att visa spara-knappen
                btnSparaPoddKategori.Visible = false;
            }
            else
            {

                // Användaren har gjort en verklig förändring → visa spara-knappen
                btnSparaPoddKategori.Visible = true;
            }
        }

        private async void btnSparaPoddKategori_Click(object sender, EventArgs e)
        {
            if (lstPoddar.SelectedItem is not Podd valdPodd)
            {
                MessageBox.Show("Välj en podd först.");
                return;
            }
            // Hämta vald kategori-id från dropdownen
            string? nyKategoriId = null;
            if (cmbPoddKategori.SelectedItem is Kategori kat)
            {
                nyKategoriId = kat.Id;
            }
            else
            {
                // "Ingen kategori" => null i databasen
                nyKategoriId = null;
            }
            // Om inget faktiskt har ändrats: gör ingenting
            if (string.Equals(nyKategoriId, _valdPoddUrsprungligKategoriId,
            StringComparison.OrdinalIgnoreCase))
            {
                btnSparaPoddKategori.Visible = false;
                return;
            }
            // Uppdatera poddens kategori och spara via tjänsten
            valdPodd.KategoriId = nyKategoriId;
            await enPoddService.UppdateraPodd(valdPodd);

            // Uppdatera "ursprungligt" värde till det nya
            _valdPoddUrsprungligKategoriId = nyKategoriId;

            // Dölj spara-knappen igen när allt gått bra
            btnSparaPoddKategori.Visible = false;
            MessageBox.Show("Kategorin har uppdaterats.");

            FyllFilterKategorier();

        }
        private async void btnLaggTillNyKategori_Click(object sender, EventArgs e)
        {
            // Öppna formuläret för att skapa en ny kategori
            var dlg = new EditKategoriForm(enKategoriService);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // 1. Vi ska uppdatera dropdownen programmässigt → ignorera events under tiden
                _ignoreKategoriEvents = true;
                try
                {
                    // 2. Ladda om kategorier från databasen
                    await LaddaKategorierAsync();
                    // 3. Fyll dropdownen i poddvyn på nytt
                    FyllPoddKategoriDropdown();
                    // 4. Försök välja den senast skapade kategorin
                    if (allaKategorier.Any())
                    {
                        var senaste = allaKategorier.Last();
                        foreach (var item in cmbPoddKategori.Items)
                        {
                            if (item is Kategori k && k.Id == senaste.Id)
                            {
                                cmbPoddKategori.SelectedItem = item;
                                break;
                            }
                        }
                    }
                }
                finally
                {
                    // 5. Efter uppdateringen ska events fungera som vanligt igen
                    _ignoreKategoriEvents = false;
                }
            }
        }

        // skapar ett streck för listboxen lstAvsnitt
        private void lstAvsnitt_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Bakgrund vid markering
            e.DrawBackground();

            // Hämta texten
            string text = lstAvsnitt.Items[e.Index].ToString();

            // Rita texten
            TextRenderer.DrawText(
                e.Graphics,
                text,
                e.Font,
                e.Bounds,
                Color.Black,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );

            // Rita linje under item
            using (Pen p = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawLine(p, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            }

            e.DrawFocusRectangle();
        }
        // skapar ett streck för listboxen lstPoddar
        private void lstPoddar_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Bakgrund vid markering
            e.DrawBackground();

            // Hämta texten
            string text = lstPoddar.Items[e.Index].ToString();

            // Rita texten
            TextRenderer.DrawText(
                e.Graphics,
                text,
                e.Font,
                e.Bounds,
                Color.Black,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );

            // Rita linje under item
            using (Pen p = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawLine(p, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            }

            e.DrawFocusRectangle();
        }

        private async void mnuBytNamn_Click(object sender, EventArgs e)
        {
            if (lstPoddar.SelectedItem is not Podd valdPodd)
            {
                MessageBox.Show("Välj en podd först.");
                return;
            }

            using (var dlg = new EditPodNameForm(valdPodd.Titel))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                string nyttNamn = dlg.NyttNamn;

                if (string.Equals(nyttNamn, valdPodd.Titel, StringComparison.Ordinal))
                    return;

                valdPodd.Titel = nyttNamn;
                await enPoddService.UppdateraPodd(valdPodd);

                await LaddaPoddarAsync();

                var uppdaterad = allaPoddar.FirstOrDefault(p => p.Id == valdPodd.Id);
                if (uppdaterad != null)
                    lstPoddar.SelectedItem = uppdaterad;

                MessageBox.Show("Poddens namn har uppdaterats.");
            }
        }

        private void mnuAndraKategori_Click(object sender, EventArgs e)
        {
            var dlg = new KategoriForm(enKategoriService);

            dlg.KategorierAndrades += async () =>
            {
                await LaddaKategorierAsync();
                await LaddaPoddarAsync();
            };

            dlg.ShowDialog(this);   // öppna som modal dialog
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {// Om stängningen kommer från användaren (dvs klick på X)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var dialog = MessageBox.Show(
                    "Vill du avsluta Podvault?",
                    "Bekräfta avslut",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialog == DialogResult.No)
                {
                    e.Cancel = true;   // Avbryt stängningen
                }
            }

        }
    }
}