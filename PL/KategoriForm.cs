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
    public partial class KategoriForm : Form
    {
        public event Action KategorierAndrades;
        private readonly KategoriService _kategoriService;
        private List<Kategori> _allaKategorier = new();
        public KategoriForm()
        {
            InitializeComponent();
        }

        public KategoriForm(KategoriService kategoriService)
        {
            InitializeComponent();
            _kategoriService = kategoriService;
            _ = LaddaKategorierAsync();
        }

        private async Task LaddaKategorierAsync()
        {
            _allaKategorier = await _kategoriService.HamtaAllaKategorier();
            lstKategorier.DataSource = null;
            lstKategorier.DisplayMember = "Namn";
            lstKategorier.ValueMember = "Id";
            lstKategorier.DataSource = _allaKategorier;
        }

        private async void btnRedigera_Click(object sender, EventArgs e)
        {
            if (lstKategorier.SelectedItem is not Kategori vald)
            {
                MessageBox.Show("Välj en kategori.");
                return;
            }

            var dlg = new EditKategoriForm(vald, _kategoriService);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                await LaddaKategorierAsync();
                KategorierAndrades?.Invoke();
            }
        }

        private async void btnTaBort_Click(object sender, EventArgs e)
        {
            if (lstKategorier.SelectedItem is not Kategori vald)
            {
                MessageBox.Show("Välj en kategori.");
                return;
            }
            var dialog = MessageBox.Show(
            $"Vill du ta bort kategorin '{vald.Namn}'?",
            "Bekräfta borttagning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                await _kategoriService.TaBortKategori(vald.Id!);
                await LaddaKategorierAsync();
                KategorierAndrades?.Invoke();
            }

        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnNyKategori_Click(object sender, EventArgs e)
        {
            var dlg = new EditKategoriForm(_kategoriService);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                await LaddaKategorierAsync();

                // Informera Mainform att kategorierna har ändrats
                KategorierAndrades?.Invoke();
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
