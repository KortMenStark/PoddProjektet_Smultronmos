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

        public Mainform()
        {
            InitializeComponent();
            enRssService = new RssService();
            enPoddService = new PoddService(new PoddRepository(new MongoDbContext()));
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
            var valtAvsnitt = hamtatfeed.Items.ElementAt(lstAvsnitt.SelectedIndex);

            string utanHtmlSammanfattning = TaBortHtml(valtAvsnitt.Summary.Text);

            string info = "Titel: " + valtAvsnitt.Title.Text + "\r\n" +
                          "Publiceringsdatum: " + valtAvsnitt.PublishDate.DateTime + "\r\n" +
                          "Sammanfattning: " + valtAvsnitt.Summary.Text;

            txtDetaljer.Text = TaBortHtml(info);
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

            await enPoddService.SparaPodd(poddFlode, rssUrl, "");
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
    }
}