using BL;
using DAL;
using DAL.Repository;
using Models_new;
using System.ServiceModel.Syndication;
using System.Linq;
using static System.Net.WebRequestMethods;

namespace PL

{
    public partial class Mainform : Form
    {
        //Detta implementerar gränssnittet f�r IRssService
        private readonly IRssService enRssService;

        //H�ller reda p� det hämtade RSS-flödet och lagrar det i hamtatfeed = feed;
        private SyndicationFeed? hamtatfeed;

        //Detta hanterar poddrelaterade operationer.
        private readonly PoddService enPoddService;

        //Detta hanterar kategorirelaterade operationer
        private readonly KategoriService enKategoriService;

        //Lokal lista för alla kategorier som laddas in i comboboxen (dropdownmenyn med kategorier)
        private List<Kategori> allaKategorier = new();

        //Lokal lista för alla poddar som laddas in i listboxen
        private List<Podd> allaPoddar = new List<Podd>();

        public Mainform()
        {
            InitializeComponent();
            enRssService = new RssService();
            enPoddService = new PoddService(new PoddRepository(new MongoDbContext()));

            // Hanterar kategori-relaterade databasoperationer
            enKategoriService = new KategoriService(
            new KategoriRepository(new MongoDbContext()),
              new PoddRepository(new MongoDbContext()));

            // Ladda alla kategorier direkt när formuläret startar
            _ = LaddaKategorierAsync();
        }

        private void GaTillRSSLage()
        {
            btnSparaPodd.Visible = true;
            btnAvprenumerera.Visible = false;
            btnAndraKategori.Visible = false;
            cmbKategori.Visible = false;
            lblNyKategori.Visible = false;

            txtKategori.Text = ""; // visa ej gammal kategori
        }

        private void GaTillSparadPoddLage()
        {
            btnSparaPodd.Visible = false;
            btnAvprenumerera.Visible = true;
            btnAndraKategori.Visible = true;
            cmbKategori.Visible = true;
            lblNyKategori.Visible = true;
        }

        //Synkroniserar UI med databasen varje gång kategorier ändras.
        private async Task LaddaKategorierAsync()
        {
            allaKategorier = await enKategoriService.HamtaAllaKategorier();

            cmbKategori.DataSource = null;
            cmbKategori.DisplayMember = "Namn";
            cmbKategori.ValueMember = "Id";
            cmbKategori.DataSource = allaKategorier;
        }

        private async Task LaddaPoddarAsync()
        {
            allaPoddar = await enPoddService.HamtaAllaPoddar();
            VisaPoddar(allaPoddar);
            FyllFilterKategorier();
        }

        private async void btnHamtaRss_ClickAsync(object sender, EventArgs e)
        {
            string url = txtRssUrl.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Ange en giltig RSS-URL.");
                return;
            }

            try
            {
                var feed = await enRssService.HamtaFlodeAsync(url);
                GaTillRSSLage();
                hamtatfeed = feed;

                txtTitel.Text = feed.Title.Text;

                lstAvsnitt.Items.Clear();

                foreach (var item in feed.Items)
                {
                    lstAvsnitt.Items.Add(item.Title.Text);
                }
            }
            catch (Exception ettFel)
            {
                MessageBox.Show("Fel vid hämtning av RSS-flöde, (OBS: Kontrollera stavningen): " + ettFel.Message);
            }
        }

        private void lstAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Skydd om inget är valt
            if (lstAvsnitt.SelectedIndex < 0)
                return;

            var valtAvsnitt = hamtatfeed.Items.ElementAt(lstAvsnitt.SelectedIndex);

            // Ta bort HTML bara från sammanfattningen
            string renSammanfattning = TaBortHtml(valtAvsnitt.Summary.Text);

            txtAvsnittTitel.Text = valtAvsnitt.Title.Text;

            // Välj själv hur datumet ska formateras
            txtPubliceringsdatum.Text = valtAvsnitt.PublishDate.DateTime.ToString("yyyy-MM-dd HH:mm");

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

        private void btnSparaPodd_Click(object sender, EventArgs e)
        {
            if (hamtatfeed == null)
            {
                MessageBox.Show("Inget RSS-flöde att spara. Hämta först.");
                return;
            }

            var dlg = new SavePoddForm(
                hamtatfeed,
                allaKategorier,
                txtRssUrl.Text,
                enPoddService,
                enKategoriService);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btnLaddaPoddar.PerformClick(); // Uppdatera listan efter sparning
            }
        }

        private async void btnLaddaPoddar_ClickAsync(object sender, EventArgs e)
        {
            await LaddaPoddarAsync();
        }

        private void VisaPoddar(IEnumerable<Podd> poddar)
        {
            lstPoddar.Items.Clear();

            foreach (var podd in poddar)
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

        private async void lstPoddar_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            if (lstPoddar.SelectedItem == null)
                return;

            GaTillSparadPoddLage();

            var valdPodd = (Podd)lstPoddar.SelectedItem;

            // Sätt poddtitel
            txtTitel.Text = valdPodd.Titel;

            // ------ Sätter kategorinamnet i textfältet ----------
            if (string.IsNullOrWhiteSpace(valdPodd.KategoriId))
            {
                // Podden har ingen kategori kopplad
                txtKategori.Text = "Ingen kategori";
            }
            else
            {
                // Försök hitta kategorin baserat på ID
                var kategori = allaKategorier
                    .FirstOrDefault(k => k.Id == valdPodd.KategoriId);

                if (kategori != null)
                    txtKategori.Text = kategori.Namn;      // Visa kategorinamn
                else
                    txtKategori.Text = "Okänd kategori";   // ID finns men matchar ingen kategori  (TA BORT NÄR VI LÖST??)
            }


            // Hämta RSS-flödet
            var feed = await enRssService.HamtaFlodeAsync(valdPodd.RssUrl);
            hamtatfeed = feed;

            lstAvsnitt.Items.Clear();

            foreach (var item in feed.Items)
            {
                lstAvsnitt.Items.Add(item.Title.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNyKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            btnSparaPodd.Visible = false;
            btnAvprenumerera.Visible = false;
            btnAndraKategori.Visible = false;
            cmbKategori.Visible = false;
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
                    btnLaddaPoddar.PerformClick();

                }

            }
        }

        private void btnHanteraKategorier_Click(object sender, EventArgs e)
        {
            var dlg = new KategoriForm(enKategoriService);

            dlg.KategorierAndrades += async () =>
            {
                await LaddaKategorierAsync();
                await LaddaPoddarAsync();   // <— FIXEN
            };

            dlg.ShowDialog();
        }

        private async void btnAndraKategori_Click(object sender, EventArgs e)
        {
            if (lstPoddar.SelectedItem is not Podd valdPodd)
            {
                MessageBox.Show("Välj en podd först.");
                return;
            }

            if (cmbKategori.SelectedItem is not Kategori valdKategori)
            {
                MessageBox.Show("Välj en kategori.");
                return;
            }

            // Sätt ny kategori
            valdPodd.KategoriId = valdKategori.Id;

            // Spara i databasen
            await enPoddService.UppdateraPodd(valdPodd);

            // Uppdatera UI
            txtKategori.Text = valdKategori.Namn;

            MessageBox.Show("Kategorin ändrades.");
        }


    }
}