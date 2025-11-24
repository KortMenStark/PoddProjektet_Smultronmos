using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Models_new;

namespace PL
{
    public partial class EditKategoriForm : Form
    {
        private readonly KategoriService _kategoriService;
        private readonly Kategori? _kategori;
        public EditKategoriForm()
        {
            InitializeComponent();
        }

        //Konstrukor för skapa ny kategori
        public EditKategoriForm(KategoriService kategoriService)
        {
            InitializeComponent();
            _kategoriService = kategoriService;
            _kategori = null;
            this.Text = "Skapa kategori";
            btnSpara.Text = "Skapa";
        }

        //Konstruktor för att redigera befintlig kategori
        public EditKategoriForm(Kategori kategori, KategoriService kategoriService)
        {
            InitializeComponent();
            _kategoriService = kategoriService;
            _kategori = kategori;
            this.Text = "Redigera kategori";
            btnSpara.Text = "Spara";
            txtNamn.Text = kategori.Namn;
        }

        private async void btnSpara_Click(object sender, EventArgs e)
        {
            string namn = txtNamn.Text.Trim();
            if (string.IsNullOrEmpty(namn))
            {
                MessageBox.Show("Ange ett namn.");
                return;
            }
            if (_kategori == null)
            {
                // Ny kategori
                var nyKat = new Kategori { Namn = namn };
                await _kategoriService.LagraNyKategori(nyKat);
            }
            else
            {
                // Redigera befintlig
                _kategori.Namn = namn;
                await _kategoriService.UppdateraKategori(_kategori);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
