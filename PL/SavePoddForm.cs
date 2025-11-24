using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Models_new;

namespace PL
{
    public partial class SavePoddForm : Form
    {
        private readonly SyndicationFeed _feed;
        private readonly List<Kategori> _kategorier;
        private readonly string _rssUrl;
        private readonly PoddService _poddService;

        public SavePoddForm()
        {
            InitializeComponent();
        }

        public SavePoddForm(SyndicationFeed feed, List<Kategori> kategorier, string rssUrl, PoddService poddService)
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
        }

        private async void btnSpara_Click(object sender, EventArgs e)
        {
            //Skapa poddflödet från RSS
            var flode = _poddService.SkapaPoddflode(_feed);

            //Sätt användarens valda namn (från textboxen)
            flode.Titel = txtNamn.Text;

            //Hantera kategori – användaren kan välja Ingen kategori
            string kategoriId = null;

            if (cmbKategori.SelectedItem is Kategori kat)
            {
                kategoriId = kat.Id;
            }

            //Försök spara podden via PoddService
            bool sparad = await _poddService.SparaPoddOmNyAsync(flode, _rssUrl, kategoriId);

            //Återkoppling till användaren
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

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
