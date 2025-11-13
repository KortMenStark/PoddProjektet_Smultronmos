using System;
using BL_Affarslager;
using Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PL_Presentationslager
{
    public partial class PoddForm : Form
    {
        private PodcastService podcastService;
        private List<Podcast> allaPoddar;

        public PoddForm()
        {
            InitializeComponent();

            podcastService = new PodcastService();
            allaPoddar = new List<Podcast>();

            this.Load += PoddForm_Load;
            dgvPoddar.SelectionChanged += dgvPoddar_SelectionChanged;
            btnLaggTill.Click += btnLaggTill_Click;
            btnTaBort.Click += btnTaBort_Click;
            btnSpara.Click += btnSpara_Click;
        }

        // 1. När formen laddas - hämta poddar och fyll grid
        private void PoddForm_Load(object? sender, EventArgs e)
        {
            LaddaPoddar();
        }

        // 2. Hämta alla poddar från service och bind till dgvPoddar
        private void LaddaPoddar()
        {
            allaPoddar = podcastService.HamtaAlla();

            dgvPoddar.DataSource = null;
            dgvPoddar.AutoGenerateColumns = true;
            dgvPoddar.DataSource = allaPoddar;
        }

        // 3. När användaren byter rad i dgvPoddar → visa vald podd i fälten
        private void dgvPoddar_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvPoddar.CurrentRow == null)
            {
                TomaFalt();
                return;
            }

            Podcast? valdPodcast = dgvPoddar.CurrentRow.DataBoundItem as Podcast;

            if (valdPodcast == null)
            {
                TomaFalt();
                return;
            }

            VisaPodcastIForm(valdPodcast);
        }

        // 4. Sätt värden i textfält och combobox utifrån en Podcast
        private void VisaPodcastIForm(Podcast podcast)
        {
            txtTitel.Text = podcast.Title;
            txtBeskrivning.Text = podcast.Description;
            txtRss.Text = podcast.FeedUrl;
            cmbKategori.Text = podcast.CategoryId;

            VisaBild(podcast);
        }

        // 5. Visa bild i PictureBox utifrån podcastens ImageUrl
        private void VisaBild(Podcast podcast)
        {
            if (string.IsNullOrWhiteSpace(podcast.ImageUrl))
            {
                picOmslag.Image = null;
                return;
            }

            try
            {
                picOmslag.LoadAsync(podcast.ImageUrl);
            }
            catch
            {
                picOmslag.Image = null;
            }
        }

        // 6. Töm alla fält när ingen podd är vald
        private void TomaFalt()
        {
            txtTitel.Text = string.Empty;
            txtBeskrivning.Text = string.Empty;
            txtRss.Text = string.Empty;
            cmbKategori.Text = string.Empty;
            picOmslag.Image = null;
        }
        // 7. Skapa en Podcast från formuläret
        private Podcast SkapaPodcastFranFormular()
        {
            Podcast podcast = new Podcast();

            podcast.Id = Guid.NewGuid().ToString();
            podcast.Title = txtTitel.Text;
            podcast.Description = txtBeskrivning.Text;
            podcast.FeedUrl = txtRss.Text;
            podcast.CategoryId = cmbKategori.Text;

            return podcast;
        }

        // 8. Klick på "Lägg till" - skapa ny podcast och spara
        private void btnLaggTill_Click(object? sender, EventArgs e)
        {
            string url = txtRss.Text;
            if (string.IsNullOrWhiteSpace(url)) return;

            Podcast nyPodcast = podcastService.SkapaPodcastFranUrl(url);
            LaddaPoddar();
        }

        // 9. Klick på "Ta bort" - ta bort vald podcast
        private void btnTaBort_Click(object? sender, EventArgs e)
        {
            if (dgvPoddar.CurrentRow == null)
            {
                return;
            }

            Podcast? valdPodcast = dgvPoddar.CurrentRow.DataBoundItem as Podcast;

            if (valdPodcast == null)
            {
                return;
            }

            podcastService.TaBort(valdPodcast.Id);
            LaddaPoddar();
            TomaFalt();
        }
        // 10. Klick på "Spara" - uppdatera vald podcast
        private void btnSpara_Click(object? sender, EventArgs e)
        {
            if (dgvPoddar.CurrentRow == null)
            {
                return;
            }

            Podcast? valdPodcast = dgvPoddar.CurrentRow.DataBoundItem as Podcast;

            if (valdPodcast == null)
            {
                return;
            }

            // Uppdatera värdena
            valdPodcast.Title = txtTitel.Text;
            valdPodcast.Description = txtBeskrivning.Text;
            valdPodcast.FeedUrl = txtRss.Text;
            valdPodcast.CategoryId = cmbKategori.Text;

            // Spara i databasen
            podcastService.Uppdatera(valdPodcast);

            // Ladda om grid
            LaddaPoddar();
        }
        private Podcast SkapaPodcastFranFalt()
        {
            Podcast podcast = new Podcast();

            podcast.Id = Guid.NewGuid().ToString();
            podcast.Title = txtTitel.Text;
            podcast.Description = txtBeskrivning.Text;
            podcast.FeedUrl = txtRss.Text;
            podcast.CategoryId = cmbKategori.Text;

            return podcast;
        }
    }
}
