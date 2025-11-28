using BL;
using Models_new;
using System.ServiceModel.Syndication;

namespace PL
{
    public partial class SavePoddForm : Form
    {
        private readonly SyndicationFeed _feed;
        private readonly List<Kategori> _kategorier;
        private readonly string _rssUrl;
        private readonly PoddService _poddService;
        private readonly KategoriService kategoriService;

        public SavePoddForm()
        {
            InitializeComponent();
        }

        public SavePoddForm(SyndicationFeed feed, List<Kategori> kategorier, string rssUrl, PoddService poddService, KategoriService kategoriService)
        {
            InitializeComponent();

            _feed = feed;
            _kategorier = kategorier;
            _rssUrl = rssUrl;
            _poddService = poddService;

            // Fyll i standardnamn från RSS-flödet
            txtNamn.Text = _feed.Title?.Text ?? string.Empty;

            // Fyll kategorilistan
            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Ingen kategori");

            foreach (var kat in _kategorier)
                cmbKategori.Items.Add(kat);

            // Gör så listan visar kategori-namn
            cmbKategori.DisplayMember = "Namn";
            cmbKategori.SelectedIndex = 0; // Ingen kategori som default
            this.kategoriService = kategoriService;
        }

        private async void btnSpara_Click(object sender, EventArgs e)
        {
            string namn = txtNamn.Text.Trim();

            // 1. Validera poddnamn (inte tomt)
            if (!Validering.Validering.KontrolleraTomText(namn, "Poddnamn", out string fel))
            {
                MessageBox.Show(fel, "Ogiltigt namn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // (valfritt) enkel längdkontroll
            if (namn.Length < 2 || namn.Length > 40)
            {
                MessageBox.Show("Poddnamnet måste vara mellan 2-40 tecken.", "Ogiltigt namn",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validera att vi faktiskt har ett feed
            if (!Validering.Validering.KontrolleraAttFlodeFinns(_feed, out fel))
            {
                MessageBox.Show(fel, "Ogiltigt flöde", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validera RSS-url (ska egentligen redan vara kollad i MainForm, men detta är extra defensivt)
            if (!Validering.Validering.KontrolleraRssUrl(_rssUrl, out fel))
            {
                MessageBox.Show(fel, "Ogiltig RSS-länk", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // === Om vi kommer hit är all validering OK ===

            // Skapa poddflödet från RSS
            var flode = _poddService.SkapaPoddflode(_feed);

            // Sätt användarens valda namn (från textboxen)
            flode.Titel = namn;

            // Hantera kategori – användaren kan välja "Ingen kategori"
            string kategoriId = null;
            if (cmbKategori.SelectedItem is Kategori kat)
            {
                kategoriId = kat.Id;
            }

            try
            {
                // Försök spara podden via PoddService
                bool sparad = await _poddService.SparaPoddOmNyAsync(flode, _rssUrl, kategoriId);

                if (sparad)
                {
                    MessageBox.Show("Podden har sparats!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podden finns redan i databasen.");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Fel vid sparande",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnNyKategori_Click(object sender, EventArgs e)
        {
            var dlg = new EditKategoriForm(kategoriService);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Uppdatera kategorilistan
                cmbKategori.Items.Clear();
                cmbKategori.Items.Add("Ingen kategori");
                var alla = await kategoriService.HamtaAllaKategorier();
                foreach (var kat in alla) cmbKategori.Items.Add(kat);
                // Välj senaste skapade kategorin
                cmbKategori.SelectedIndex = cmbKategori.Items.Count - 1;
            }
        }
    }
}
