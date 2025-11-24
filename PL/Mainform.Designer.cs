namespace PL
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHamtaRss = new Button();
            lstAvsnitt = new ListBox();
            txtRssUrl = new TextBox();
            btnSparaPodd = new Button();
            lstPoddar = new ListBox();
            btnLaddaPoddar = new Button();
            lblKategori = new Label();
            cmbKategori = new ComboBox();
            btnAndraKategori = new Button();
            btnTaBortKategori = new Button();
            btnLaggTillKategori = new Button();
            txtNyKategori = new TextBox();
            txtTitel = new TextBox();
            txtBeskrivning = new TextBox();
            txtPubliceringsdatum = new TextBox();
            cbmFilterKategori = new ComboBox();
            labelKategori = new Label();
            lblTitel = new Label();
            lblBeskrivning = new Label();
            lblUtgivningsdatum = new Label();
            btnAvprenumerera = new Button();
            txtAvsnittTitel = new TextBox();
            lblAvsnittTitel = new Label();
            btnHanteraKategorier = new Button();
            txtKategori = new TextBox();
            lblAktuellkategori = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnHamtaRss
            // 
            btnHamtaRss.Location = new Point(577, 11);
            btnHamtaRss.Margin = new Padding(2);
            btnHamtaRss.Name = "btnHamtaRss";
            btnHamtaRss.Size = new Size(101, 26);
            btnHamtaRss.TabIndex = 0;
            btnHamtaRss.Text = "Hämta RSS";
            btnHamtaRss.UseVisualStyleBackColor = true;
            btnHamtaRss.Click += btnHamtaRss_ClickAsync;
            // 
            // lstAvsnitt
            // 
            lstAvsnitt.FormattingEnabled = true;
            lstAvsnitt.Location = new Point(12, 148);
            lstAvsnitt.Margin = new Padding(2);
            lstAvsnitt.Name = "lstAvsnitt";
            lstAvsnitt.Size = new Size(140, 395);
            lstAvsnitt.TabIndex = 1;
            lstAvsnitt.SelectedIndexChanged += lstAvsnitt_SelectedIndexChanged;
            // 
            // txtRssUrl
            // 
            txtRssUrl.Location = new Point(160, 12);
            txtRssUrl.Margin = new Padding(2);
            txtRssUrl.Name = "txtRssUrl";
            txtRssUrl.Size = new Size(413, 25);
            txtRssUrl.TabIndex = 3;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.BackColor = Color.FromArgb(29, 185, 84);
            btnSparaPodd.FlatAppearance.BorderSize = 0;
            btnSparaPodd.FlatStyle = FlatStyle.Flat;
            btnSparaPodd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSparaPodd.ForeColor = Color.Black;
            btnSparaPodd.Location = new Point(8, 23);
            btnSparaPodd.Margin = new Padding(2);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(146, 35);
            btnSparaPodd.TabIndex = 4;
            btnSparaPodd.Text = "Spara";
            btnSparaPodd.UseVisualStyleBackColor = false;
            btnSparaPodd.Click += btnSparaPodd_Click;
            // 
            // lstPoddar
            // 
            lstPoddar.FormattingEnabled = true;
            lstPoddar.Location = new Point(564, 232);
            lstPoddar.Margin = new Padding(2);
            lstPoddar.Name = "lstPoddar";
            lstPoddar.Size = new Size(246, 310);
            lstPoddar.TabIndex = 5;
            lstPoddar.SelectedIndexChanged += lstPoddar_SelectedIndexChangedAsync;
            // 
            // btnLaddaPoddar
            // 
            btnLaddaPoddar.BackColor = Color.FromArgb(29, 185, 84);
            btnLaddaPoddar.FlatAppearance.BorderSize = 0;
            btnLaddaPoddar.FlatStyle = FlatStyle.Flat;
            btnLaddaPoddar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLaddaPoddar.ForeColor = Color.Black;
            btnLaddaPoddar.Location = new Point(8, 199);
            btnLaddaPoddar.Margin = new Padding(2);
            btnLaddaPoddar.Name = "btnLaddaPoddar";
            btnLaddaPoddar.Size = new Size(146, 36);
            btnLaddaPoddar.TabIndex = 6;
            btnLaddaPoddar.Text = "\"Ladda\" sparade poddar";
            btnLaddaPoddar.UseVisualStyleBackColor = false;
            btnLaddaPoddar.Click += btnLaddaPoddar_ClickAsync;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.ForeColor = SystemColors.MenuHighlight;
            lblKategori.Location = new Point(919, 189);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(58, 17);
            lblKategori.TabIndex = 7;
            lblKategori.Text = "Kategori";
            lblKategori.Click += label1_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(919, 209);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(121, 25);
            cmbKategori.TabIndex = 8;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.Location = new Point(919, 284);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(105, 26);
            btnAndraKategori.TabIndex = 9;
            btnAndraKategori.Text = "Ändra kategori";
            btnAndraKategori.UseVisualStyleBackColor = true;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(919, 252);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(105, 26);
            btnTaBortKategori.TabIndex = 10;
            btnTaBortKategori.Text = "Ta bort kategori";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Location = new Point(919, 316);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(105, 26);
            btnLaggTillKategori.TabIndex = 11;
            btnLaggTillKategori.Text = "Lägg till kategori";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // txtNyKategori
            // 
            txtNyKategori.Location = new Point(919, 348);
            txtNyKategori.Name = "txtNyKategori";
            txtNyKategori.Size = new Size(121, 25);
            txtNyKategori.TabIndex = 12;
            txtNyKategori.TextChanged += txtNyKategori_TextChanged;
            // 
            // txtTitel
            // 
            txtTitel.BackColor = SystemColors.Window;
            txtTitel.Location = new Point(160, 47);
            txtTitel.Name = "txtTitel";
            txtTitel.ReadOnly = true;
            txtTitel.Size = new Size(304, 25);
            txtTitel.TabIndex = 13;
            // 
            // txtBeskrivning
            // 
            txtBeskrivning.BackColor = SystemColors.Window;
            txtBeskrivning.Location = new Point(160, 148);
            txtBeskrivning.Multiline = true;
            txtBeskrivning.Name = "txtBeskrivning";
            txtBeskrivning.ReadOnly = true;
            txtBeskrivning.ScrollBars = ScrollBars.Vertical;
            txtBeskrivning.Size = new Size(344, 394);
            txtBeskrivning.TabIndex = 14;
            // 
            // txtPubliceringsdatum
            // 
            txtPubliceringsdatum.BackColor = SystemColors.Window;
            txtPubliceringsdatum.Location = new Point(160, 625);
            txtPubliceringsdatum.Name = "txtPubliceringsdatum";
            txtPubliceringsdatum.ReadOnly = true;
            txtPubliceringsdatum.Size = new Size(344, 25);
            txtPubliceringsdatum.TabIndex = 15;
            // 
            // cbmFilterKategori
            // 
            cbmFilterKategori.FormattingEnabled = true;
            cbmFilterKategori.Location = new Point(564, 198);
            cbmFilterKategori.Name = "cbmFilterKategori";
            cbmFilterKategori.Size = new Size(246, 25);
            cbmFilterKategori.TabIndex = 16;
            cbmFilterKategori.SelectedIndexChanged += cbmFilterKategori_SelectedIndexChanged;
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.ForeColor = SystemColors.MenuHighlight;
            labelKategori.Location = new Point(564, 171);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(89, 17);
            labelKategori.TabIndex = 17;
            labelKategori.Text = "Mina kategori";
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.ForeColor = SystemColors.MenuHighlight;
            lblTitel.Location = new Point(108, 50);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(32, 17);
            lblTitel.TabIndex = 18;
            lblTitel.Text = "Titel";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.ForeColor = SystemColors.MenuHighlight;
            lblBeskrivning.Location = new Point(160, 120);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(73, 17);
            lblBeskrivning.TabIndex = 19;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // lblUtgivningsdatum
            // 
            lblUtgivningsdatum.AutoSize = true;
            lblUtgivningsdatum.ForeColor = SystemColors.MenuHighlight;
            lblUtgivningsdatum.Location = new Point(160, 605);
            lblUtgivningsdatum.Name = "lblUtgivningsdatum";
            lblUtgivningsdatum.Size = new Size(106, 17);
            lblUtgivningsdatum.TabIndex = 20;
            lblUtgivningsdatum.Text = "Utgivningsdatum";
            // 
            // btnAvprenumerera
            // 
            btnAvprenumerera.BackColor = Color.FromArgb(29, 185, 84);
            btnAvprenumerera.FlatAppearance.BorderSize = 0;
            btnAvprenumerera.FlatStyle = FlatStyle.Flat;
            btnAvprenumerera.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAvprenumerera.ForeColor = Color.Black;
            btnAvprenumerera.Location = new Point(8, 141);
            btnAvprenumerera.Name = "btnAvprenumerera";
            btnAvprenumerera.Size = new Size(146, 36);
            btnAvprenumerera.TabIndex = 21;
            btnAvprenumerera.Text = "Avprenumerera";
            btnAvprenumerera.UseVisualStyleBackColor = false;
            btnAvprenumerera.Click += btnAvprenumerera_ClickAsync;
            // 
            // txtAvsnittTitel
            // 
            txtAvsnittTitel.BackColor = SystemColors.Window;
            txtAvsnittTitel.Location = new Point(160, 83);
            txtAvsnittTitel.Margin = new Padding(3, 2, 3, 2);
            txtAvsnittTitel.Name = "txtAvsnittTitel";
            txtAvsnittTitel.ReadOnly = true;
            txtAvsnittTitel.Size = new Size(304, 25);
            txtAvsnittTitel.TabIndex = 22;
            // 
            // lblAvsnittTitel
            // 
            lblAvsnittTitel.AutoSize = true;
            lblAvsnittTitel.ForeColor = SystemColors.MenuHighlight;
            lblAvsnittTitel.Location = new Point(81, 92);
            lblAvsnittTitel.Name = "lblAvsnittTitel";
            lblAvsnittTitel.Size = new Size(73, 17);
            lblAvsnittTitel.TabIndex = 23;
            lblAvsnittTitel.Text = "Avsnittstitel";
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.BackColor = Color.FromArgb(29, 185, 84);
            btnHanteraKategorier.FlatAppearance.BorderSize = 0;
            btnHanteraKategorier.FlatStyle = FlatStyle.Flat;
            btnHanteraKategorier.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnHanteraKategorier.ForeColor = Color.Black;
            btnHanteraKategorier.Location = new Point(8, 83);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(146, 35);
            btnHanteraKategorier.TabIndex = 22;
            btnHanteraKategorier.Text = "Hantera kategorier";
            btnHanteraKategorier.UseVisualStyleBackColor = true;
            btnHanteraKategorier.Click += btnHanteraKategorier_Click;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(160, 573);
            txtKategori.Margin = new Padding(3, 2, 3, 2);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(344, 25);
            txtKategori.TabIndex = 24;
            // 
            // lblAktuellkategori
            // 
            lblAktuellkategori.AutoSize = true;
            lblAktuellkategori.ForeColor = SystemColors.MenuHighlight;
            lblAktuellkategori.Location = new Point(160, 545);
            lblAktuellkategori.Name = "lblAktuellkategori";
            lblAktuellkategori.Size = new Size(58, 17);
            lblAktuellkategori.TabIndex = 25;
            lblAktuellkategori.Text = "Kategori";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1503, 60);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 0;
            label1.Text = "Podcast Manager";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(btnSparaPodd);
            panel2.Controls.Add(btnHanteraKategorier);
            panel2.Controls.Add(btnAvprenumerera);
            panel2.Controls.Add(btnLaddaPoddar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 771);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 40, 40);
            panel3.Controls.Add(lstAvsnitt);
            panel3.Controls.Add(txtBeskrivning);
            panel3.Controls.Add(txtKategori);
            panel3.Controls.Add(txtNyKategori);
            panel3.Controls.Add(labelKategori);
            panel3.Controls.Add(btnLaggTillKategori);
            panel3.Controls.Add(lblTitel);
            panel3.Controls.Add(btnAndraKategori);
            panel3.Controls.Add(btnTaBortKategori);
            panel3.Controls.Add(cbmFilterKategori);
            panel3.Controls.Add(lblAvsnittTitel);
            panel3.Controls.Add(lblKategori);
            panel3.Controls.Add(cmbKategori);
            panel3.Controls.Add(lstPoddar);
            panel3.Controls.Add(txtTitel);
            panel3.Controls.Add(lblAktuellkategori);
            panel3.Controls.Add(txtAvsnittTitel);
            panel3.Controls.Add(txtPubliceringsdatum);
            panel3.Controls.Add(lblBeskrivning);
            panel3.Controls.Add(lblUtgivningsdatum);
            panel3.Controls.Add(txtRssUrl);
            panel3.Controls.Add(btnHamtaRss);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 60);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(1303, 771);
            panel3.TabIndex = 28;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1503, 831);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "Mainform";
            Text = "Podcast Manager";
            Load += Mainform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHamtaRss;
        private ListBox lstAvsnitt;
        private TextBox txtRssUrl;
        private Button btnSparaPodd;
        private ListBox lstPoddar;
        private Button btnLaddaPoddar;
        private Label lblKategori;
        private ComboBox cmbKategori;
        private Button btnAndraKategori;
        private Button btnTaBortKategori;
        private Button btnLaggTillKategori;
        private TextBox txtNyKategori;
        private TextBox txtTitel;
        private TextBox txtBeskrivning;
        private TextBox txtPubliceringsdatum;
        private ComboBox cbmFilterKategori;
        private Label labelKategori;
        private Label lblTitel;
        private Label lblBeskrivning;
        private Label lblUtgivningsdatum;
        private Button btnAvprenumerera;
        private TextBox txtAvsnittTitel;
        private Label lblAvsnittTitel;
        private Button btnHanteraKategorier;
        private TextBox txtKategori;
        private Label lblAktuellkategori;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
    }
}
