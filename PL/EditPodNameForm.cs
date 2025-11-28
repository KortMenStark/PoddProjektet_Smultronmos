namespace PL
{
    public partial class EditPodNameForm : Form
    {
        public string NyttNamn => txtNyttNamn.Text.Trim();

        public EditPodNameForm(string gammaltNamn)
        {
            InitializeComponent();
            txtNyttNamn.Text = gammaltNamn;
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            string namn = txtNyttNamn.Text.Trim();

            // Validera (tom kontroll)
            if (!Validering.Validering.KontrolleraTomText(namn, "Poddnamn", out string fel))
            {
                MessageBox.Show(fel, "Ogiltigt namn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Längd för poddnamn
            if (namn.Length < 2 || namn.Length > 40)
            {
                MessageBox.Show("Poddnamnet måste vara mellan 2–40 tecken.",
                    "Ogiltigt namn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
