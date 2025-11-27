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
using PL.Validering;

using PL.ValideringMapp;

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

            // 1. Enkel UI-kontroll (helt OK enligt uppgiften)
            if (string.IsNullOrEmpty(namn))
            {
                MessageBox.Show("Ange ett kategorinamn.");
                return;
            }

            try
            {
                // 2. FORMELL VALIDERING – ska ske i PL (presentationslagret)
                // Detta använder valideringsklass i PL.Validering
                var kategori = new Kategori { Namn = namn };
                KategoriValidering.Validera(kategori);

                // 3. Försök spara – BL skickar vidare till DAL som använder transaktioner
                if (_kategori == null)
                {
                    // Ny kategori
                    await _kategoriService.LagraNyKategori(kategori);
                }
                else
                {
                    // Redigera befintlig
                    _kategori.Namn = namn;
                    await _kategoriService.UppdateraKategori(_kategori);
                }

                // 4. ALLT HAR LYCKATS 
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // UI rollback – visa fel, gör INGA ändringar
                MessageBox.Show(ex.Message, "Fel vid sparande", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
