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
            btnHanteraKategorier = new Button();
            SuspendLayout();
            // 
            // btnHamtaRss
            // 
            btnHamtaRss.Location = new Point(488, 23);
            btnHamtaRss.Margin = new Padding(2, 3, 2, 3);
            btnHamtaRss.Name = "btnHamtaRss";
            btnHamtaRss.Size = new Size(115, 31);
            btnHamtaRss.TabIndex = 0;
            btnHamtaRss.Text = "Hämta RSS";
            btnHamtaRss.UseVisualStyleBackColor = true;
            btnHamtaRss.Click += btnHamtaRss_ClickAsync;
            // 
            // lstAvsnitt
            // 
            lstAvsnitt.FormattingEnabled = true;
            lstAvsnitt.Location = new Point(9, 69);
            lstAvsnitt.Margin = new Padding(2, 3, 2, 3);
            lstAvsnitt.Name = "lstAvsnitt";
            lstAvsnitt.Size = new Size(281, 604);
            lstAvsnitt.TabIndex = 1;
            lstAvsnitt.SelectedIndexChanged += lstAvsnitt_SelectedIndexChanged;
            // 
            // txtRssUrl
            // 
            txtRssUrl.Location = new Point(9, 23);
            txtRssUrl.Margin = new Padding(2, 3, 2, 3);
            txtRssUrl.Name = "txtRssUrl";
            txtRssUrl.Size = new Size(471, 27);
            txtRssUrl.TabIndex = 3;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.Location = new Point(9, 681);
            btnSparaPodd.Margin = new Padding(2, 3, 2, 3);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(281, 41);
            btnSparaPodd.TabIndex = 4;
            btnSparaPodd.Text = "Spara";
            btnSparaPodd.UseVisualStyleBackColor = true;
            btnSparaPodd.Click += btnSparaPodd_Click;
            // 
            // lstPoddar
            // 
            lstPoddar.FormattingEnabled = true;
            lstPoddar.Location = new Point(714, 153);
            lstPoddar.Margin = new Padding(2, 3, 2, 3);
            lstPoddar.Name = "lstPoddar";
            lstPoddar.Size = new Size(281, 364);
            lstPoddar.TabIndex = 5;
            lstPoddar.SelectedIndexChanged += lstPoddar_SelectedIndexChangedAsync;
            // 
            // btnLaddaPoddar
            // 
            btnLaddaPoddar.Location = new Point(714, 524);
            btnLaddaPoddar.Margin = new Padding(2, 3, 2, 3);
            btnLaddaPoddar.Name = "btnLaddaPoddar";
            btnLaddaPoddar.Size = new Size(281, 43);
            btnLaddaPoddar.TabIndex = 6;
            btnLaddaPoddar.Text = "\"Ladda\" sparade poddar";
            btnLaddaPoddar.UseVisualStyleBackColor = true;
            btnLaddaPoddar.Click += btnLaddaPoddar_ClickAsync;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(1151, 292);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 7;
            lblKategori.Text = "Kategori";
            lblKategori.Click += label1_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(1151, 316);
            cmbKategori.Margin = new Padding(3, 4, 3, 4);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(138, 28);
            cmbKategori.TabIndex = 8;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.Location = new Point(1151, 432);
            btnAndraKategori.Margin = new Padding(3, 4, 3, 4);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(120, 31);
            btnAndraKategori.TabIndex = 9;
            btnAndraKategori.Text = "Ändra kategori";
            btnAndraKategori.UseVisualStyleBackColor = true;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(1151, 371);
            btnTaBortKategori.Margin = new Padding(3, 4, 3, 4);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(120, 31);
            btnTaBortKategori.TabIndex = 10;
            btnTaBortKategori.Text = "Ta bort kategori";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Location = new Point(1151, 488);
            btnLaggTillKategori.Margin = new Padding(3, 4, 3, 4);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(120, 31);
            btnLaggTillKategori.TabIndex = 11;
            btnLaggTillKategori.Text = "Lägg till kategori";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // txtNyKategori
            // 
            txtNyKategori.Location = new Point(1278, 488);
            txtNyKategori.Margin = new Padding(3, 4, 3, 4);
            txtNyKategori.Name = "txtNyKategori";
            txtNyKategori.Size = new Size(175, 27);
            txtNyKategori.TabIndex = 12;
            txtNyKategori.TextChanged += txtNyKategori_TextChanged;
            // 
            // txtTitel
            // 
            txtTitel.BackColor = SystemColors.Window;
            txtTitel.Location = new Point(304, 93);
            txtTitel.Margin = new Padding(3, 4, 3, 4);
            txtTitel.Name = "txtTitel";
            txtTitel.ReadOnly = true;
            txtTitel.Size = new Size(393, 27);
            txtTitel.TabIndex = 13;
            // 
            // txtBeskrivning
            // 
            txtBeskrivning.BackColor = SystemColors.Window;
            txtBeskrivning.Location = new Point(304, 152);
            txtBeskrivning.Margin = new Padding(3, 4, 3, 4);
            txtBeskrivning.Multiline = true;
            txtBeskrivning.Name = "txtBeskrivning";
            txtBeskrivning.ReadOnly = true;
            txtBeskrivning.ScrollBars = ScrollBars.Vertical;
            txtBeskrivning.Size = new Size(393, 463);
            txtBeskrivning.TabIndex = 14;
            // 
            // txtPubliceringsdatum
            // 
            txtPubliceringsdatum.BackColor = SystemColors.Window;
            txtPubliceringsdatum.Location = new Point(304, 644);
            txtPubliceringsdatum.Margin = new Padding(3, 4, 3, 4);
            txtPubliceringsdatum.Name = "txtPubliceringsdatum";
            txtPubliceringsdatum.ReadOnly = true;
            txtPubliceringsdatum.Size = new Size(393, 27);
            txtPubliceringsdatum.TabIndex = 15;
            // 
            // cbmFilterKategori
            // 
            cbmFilterKategori.FormattingEnabled = true;
            cbmFilterKategori.Location = new Point(714, 93);
            cbmFilterKategori.Margin = new Padding(3, 4, 3, 4);
            cbmFilterKategori.Name = "cbmFilterKategori";
            cbmFilterKategori.Size = new Size(281, 28);
            cbmFilterKategori.TabIndex = 16;
            cbmFilterKategori.SelectedIndexChanged += cbmFilterKategori_SelectedIndexChanged;
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Location = new Point(714, 64);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(101, 20);
            labelKategori.TabIndex = 17;
            labelKategori.Text = "Mina kategori";
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(304, 64);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(38, 20);
            lblTitel.TabIndex = 18;
            lblTitel.Text = "Titel";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(304, 128);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(84, 20);
            lblBeskrivning.TabIndex = 19;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // lblUtgivningsdatum
            // 
            lblUtgivningsdatum.AutoSize = true;
            lblUtgivningsdatum.Location = new Point(304, 620);
            lblUtgivningsdatum.Name = "lblUtgivningsdatum";
            lblUtgivningsdatum.Size = new Size(122, 20);
            lblUtgivningsdatum.TabIndex = 20;
            lblUtgivningsdatum.Text = "Utgivningsdatum";
            // 
            // btnAvprenumerera
            // 
            btnAvprenumerera.Location = new Point(714, 573);
            btnAvprenumerera.Margin = new Padding(3, 4, 3, 4);
            btnAvprenumerera.Name = "btnAvprenumerera";
            btnAvprenumerera.Size = new Size(281, 43);
            btnAvprenumerera.TabIndex = 21;
            btnAvprenumerera.Text = "Avprenumerera";
            btnAvprenumerera.UseVisualStyleBackColor = true;
            btnAvprenumerera.Click += btnAvprenumerera_ClickAsync;
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.Location = new Point(9, 729);
            btnHanteraKategorier.Margin = new Padding(3, 4, 3, 4);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(281, 41);
            btnHanteraKategorier.TabIndex = 22;
            btnHanteraKategorier.Text = "Hantera kategorier";
            btnHanteraKategorier.UseVisualStyleBackColor = true;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 815);
            Controls.Add(btnHanteraKategorier);
            Controls.Add(btnAvprenumerera);
            Controls.Add(lblUtgivningsdatum);
            Controls.Add(lblBeskrivning);
            Controls.Add(lblTitel);
            Controls.Add(labelKategori);
            Controls.Add(cbmFilterKategori);
            Controls.Add(txtPubliceringsdatum);
            Controls.Add(txtBeskrivning);
            Controls.Add(txtTitel);
            Controls.Add(lstPoddar);
            Controls.Add(txtNyKategori);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(btnTaBortKategori);
            Controls.Add(btnAndraKategori);
            Controls.Add(cmbKategori);
            Controls.Add(lblKategori);
            Controls.Add(btnLaddaPoddar);
            Controls.Add(btnSparaPodd);
            Controls.Add(txtRssUrl);
            Controls.Add(lstAvsnitt);
            Controls.Add(btnHamtaRss);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Mainform";
            Text = "Form1";
            Load += Mainform_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnHanteraKategorier;
    }
}
