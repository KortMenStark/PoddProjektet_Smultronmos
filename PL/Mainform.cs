using BL;
using DAL;
using DAL.Repository;
using Models_new;
using System.ServiceModel.Syndication;
using static System.Net.WebRequestMethods;

namespace PL

{
    public partial class Mainform : Form
    {
        //Detta implementerar gränssnittet för IRssService
        private readonly IRssService enRssService;

        //Håller reda på det hämtade RSS-flödet och lagrar det i hamtatfeed = feed;
        private SyndicationFeed? hamtatfeed;

        //Detta hanterar poddrelaterade operationer.
        private readonly PoddService enPoddService;

        //Detta hanterar kategorirelaterade operationer
        private readonly KategoriService enKategoriService;

        //Lokal lista för alla kategorier som laddas in i comboboxen (dropdownmenyn med kategorier)
        private List<Kategori> allaKategorier = new();

        public Mainform()
        {
            InitializeComponent();
            enRssService = new RssService();
            enPoddService = new PoddService(new PoddRepository(new MongoDbContext()));

            // Hanterar kategori-relaterade databasoperationer
            enKategoriService = new KategoriService(new KategoriRepository(new MongoDbContext()));

            // Ladda alla kategorier direkt när formuläret startar
            _ = LaddaKategorierAsync();
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
                hamtatfeed = feed;

                lstAvsnitt.Items.Clear();

                foreach (var item in feed.Items)
                {
                    lstAvsnitt.Items.Add(item.Title.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fel vid hämtning av RSS-flöde: " + ex.Message);
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

            // Skriv ut i TRE olika textboxes
            txtTitel.Text = valtAvsnitt.Title.Text;

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

        private async void btnSparaPodd_ClickAsync(object sender, EventArgs e)
        {
            if (hamtatfeed == null)
            {
                MessageBox.Show("Inget RSS-flöde att spara. Hämta ett flöde först.");
                return;
            }

            string rssUrl = txtRssUrl.Text;
            var poddFlode = enPoddService.SkapaPoddflode(hamtatfeed);

            string kategoriId = cmbKategori.SelectedValue?.ToString() ?? "";

            await enPoddService.SparaPodd(poddFlode, rssUrl, kategoriId);
            MessageBox.Show("Podden har sparats.");

            txtRssUrl.Clear();
            lstAvsnitt.Items.Clear();
            txtDetaljer.Clear();
            hamtatfeed = null;
        }

        private async void btnLaddaPoddar_ClickAsync(object sender, EventArgs e)
        {
            lstPoddar.Items.Clear();

            var allaPoddar = await enPoddService.HamtaAllaPoddar();

            foreach (var podd in allaPoddar)
            {
                lstPoddar.Items.Add(podd);
            }
        }

        private async void lstPoddar_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            if (lstPoddar.SelectedItem == null)
                return;

            var valdPodd = (Podd)lstPoddar.SelectedItem;
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

        private async void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem is not Kategori kat)
                return;
            var result = MessageBox.Show(
               $"Vill du verkligen radera kategorin '{kat.Namn}'?",
               "Bekräfta radering",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            await enKategoriService.TaBortKategori(kat.Id);
            await LaddaKategorierAsync();
        }

        private void txtNyKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNyKategori.Text))
            {
                MessageBox.Show("Ange ett kategorinamn.");
                return;
            }

            var nyKategori = new Kategori { Namn = txtNyKategori.Text };

            await enKategoriService.LagraNyKategori(nyKategori);
            await LaddaKategorierAsync();

            txtNyKategori.Clear();
        }

        private async void btnAndraKategori_Click(object sender, EventArgs e)
        {
            if (lstPoddar.SelectedItem is not Podd valdPodd)
            {
                MessageBox.Show("Välj en podd först.");
                return;
            }
            string nyKategoriId = cmbKategori.SelectedValue?.ToString() ?? "";
            valdPodd.KategoriId = nyKategoriId;

            await enPoddService.UppdateraPodd(valdPodd);
            MessageBox.Show("Kategorin ändrades.");
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
    }
}