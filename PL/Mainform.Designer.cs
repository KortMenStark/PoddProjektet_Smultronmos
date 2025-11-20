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
            SuspendLayout();
            // 
            // btnHamtaRss
            // 
            btnHamtaRss.Location = new Point(424, 15);
            btnHamtaRss.Margin = new Padding(2);
            btnHamtaRss.Name = "btnHamtaRss";
            btnHamtaRss.Size = new Size(78, 20);
            btnHamtaRss.TabIndex = 0;
            btnHamtaRss.Text = "HÃ¤mta RSS";
            btnHamtaRss.UseVisualStyleBackColor = true;
            btnHamtaRss.Click += btnHamtaRss_ClickAsync;
            // 
            // lstAvsnitt
            // 
            lstAvsnitt.FormattingEnabled = true;
            lstAvsnitt.Location = new Point(15, 34);
            lstAvsnitt.Margin = new Padding(2);
            lstAvsnitt.Name = "lstAvsnitt";
            lstAvsnitt.Size = new Size(246, 454);
            lstAvsnitt.TabIndex = 1;
            lstAvsnitt.SelectedIndexChanged += lstAvsnitt_SelectedIndexChanged;
            // 
            // txtRssUrl
            // 
            txtRssUrl.Location = new Point(8, 17);
            txtRssUrl.Margin = new Padding(2);
            txtRssUrl.Name = "txtRssUrl";
            txtRssUrl.Size = new Size(413, 23);
            txtRssUrl.TabIndex = 3;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.Location = new Point(8, 511);
            btnSparaPodd.Margin = new Padding(2);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(78, 20);
            btnSparaPodd.TabIndex = 4;
            btnSparaPodd.Text = "Spara";
            btnSparaPodd.UseVisualStyleBackColor = true;
            btnSparaPodd.Click += btnSparaPodd_ClickAsync;
            // 
            // lstPoddar
            // 
            lstPoddar.FormattingEnabled = true;
            lstPoddar.Location = new Point(625, 76);
            lstPoddar.Margin = new Padding(2);
            lstPoddar.Name = "lstPoddar";
            lstPoddar.Size = new Size(246, 199);
            lstPoddar.TabIndex = 5;
            lstPoddar.SelectedIndexChanged += lstPoddar_SelectedIndexChangedAsync;
            // 
            // btnLaddaPoddar
            // 
            btnLaddaPoddar.Location = new Point(625, 279);
            btnLaddaPoddar.Margin = new Padding(2);
            btnLaddaPoddar.Name = "btnLaddaPoddar";
            btnLaddaPoddar.Size = new Size(245, 32);
            btnLaddaPoddar.TabIndex = 6;
            btnLaddaPoddar.Text = "\"Ladda\" sparade poddar";
            btnLaddaPoddar.UseVisualStyleBackColor = true;
            btnLaddaPoddar.Click += btnLaddaPoddar_ClickAsync;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(1151, 34);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(51, 15);
            lblKategori.TabIndex = 7;
            lblKategori.Text = "Kategori";
            lblKategori.Click += label1_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(1151, 52);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(121, 23);
            cmbKategori.TabIndex = 8;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.Location = new Point(1151, 148);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(105, 23);
            btnAndraKategori.TabIndex = 9;
            btnAndraKategori.Text = "Ändra kategori";
            btnAndraKategori.UseVisualStyleBackColor = true;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(1151, 99);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(105, 23);
            btnTaBortKategori.TabIndex = 10;
            btnTaBortKategori.Text = "Ta bort kategori";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Location = new Point(1045, 221);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(105, 23);
            btnLaggTillKategori.TabIndex = 11;
            btnLaggTillKategori.Text = "Lägg till kategori";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // txtNyKategori
            // 
            txtNyKategori.Location = new Point(1156, 221);
            txtNyKategori.Name = "txtNyKategori";
            txtNyKategori.Size = new Size(100, 23);
            txtNyKategori.TabIndex = 12;
            txtNyKategori.TextChanged += txtNyKategori_TextChanged;
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(266, 61);
            txtTitel.Name = "txtTitel";
            txtTitel.ReadOnly = true;
            txtTitel.Size = new Size(344, 23);
            txtTitel.TabIndex = 13;
            // 
            // txtBeskrivning
            // 
            txtBeskrivning.Location = new Point(263, 114);
            txtBeskrivning.Multiline = true;
            txtBeskrivning.Name = "txtBeskrivning";
            txtBeskrivning.ReadOnly = true;
            txtBeskrivning.ScrollBars = ScrollBars.Vertical;
            txtBeskrivning.Size = new Size(239, 93);
            txtBeskrivning.TabIndex = 14;
            // 
            // txtPubliceringsdatum
            // 
            txtPubliceringsdatum.Location = new Point(266, 252);
            txtPubliceringsdatum.Name = "txtPubliceringsdatum";
            txtPubliceringsdatum.ReadOnly = true;
            txtPubliceringsdatum.Size = new Size(239, 23);
            txtPubliceringsdatum.TabIndex = 15;
            // 
            // cbmFilterKategori
            // 
            cbmFilterKategori.FormattingEnabled = true;
            cbmFilterKategori.Location = new Point(625, 45);
            cbmFilterKategori.Name = "cbmFilterKategori";
            cbmFilterKategori.Size = new Size(245, 23);
            cbmFilterKategori.TabIndex = 16;
            cbmFilterKategori.SelectedIndexChanged += cbmFilterKategori_SelectedIndexChanged;
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Location = new Point(625, 25);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(51, 15);
            labelKategori.TabIndex = 17;
            labelKategori.Text = "Kategori";
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(266, 42);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(29, 15);
            lblTitel.TabIndex = 18;
            lblTitel.Text = "Titel";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(266, 96);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(68, 15);
            lblBeskrivning.TabIndex = 19;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // lblUtgivningsdatum
            // 
            lblUtgivningsdatum.AutoSize = true;
            lblUtgivningsdatum.Location = new Point(266, 229);
            lblUtgivningsdatum.Name = "lblUtgivningsdatum";
            lblUtgivningsdatum.Size = new Size(99, 15);
            lblUtgivningsdatum.TabIndex = 20;
            lblUtgivningsdatum.Text = "Utgivningsdatum";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 611);
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
            Margin = new Padding(2);
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
    }
}
