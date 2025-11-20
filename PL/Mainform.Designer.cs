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
            txtDetaljer = new TextBox();
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
            btnAvprenumerera = new Button();
            SuspendLayout();
            // 
            // btnHamtaRss
            // 
            btnHamtaRss.Location = new Point(485, 20);
            btnHamtaRss.Margin = new Padding(2, 3, 2, 3);
            btnHamtaRss.Name = "btnHamtaRss";
            btnHamtaRss.Size = new Size(89, 27);
            btnHamtaRss.TabIndex = 0;
            btnHamtaRss.Text = "HÃ¤mta RSS";
            btnHamtaRss.UseVisualStyleBackColor = true;
            btnHamtaRss.Click += btnHamtaRss_ClickAsync;
            // 
            // lstAvsnitt
            // 
            lstAvsnitt.FormattingEnabled = true;
            lstAvsnitt.Location = new Point(17, 45);
            lstAvsnitt.Margin = new Padding(2, 3, 2, 3);
            lstAvsnitt.Name = "lstAvsnitt";
            lstAvsnitt.Size = new Size(281, 264);
            lstAvsnitt.TabIndex = 1;
            lstAvsnitt.SelectedIndexChanged += lstAvsnitt_SelectedIndexChanged;
            // 
            // txtDetaljer
            // 
            txtDetaljer.Location = new Point(295, 60);
            txtDetaljer.Margin = new Padding(2, 3, 2, 3);
            txtDetaljer.Multiline = true;
            txtDetaljer.Name = "txtDetaljer";
            txtDetaljer.ReadOnly = true;
            txtDetaljer.ScrollBars = ScrollBars.Both;
            txtDetaljer.Size = new Size(281, 264);
            txtDetaljer.TabIndex = 2;
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
            btnSparaPodd.Location = new Point(9, 340);
            btnSparaPodd.Margin = new Padding(2, 3, 2, 3);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(89, 27);
            btnSparaPodd.TabIndex = 4;
            btnSparaPodd.Text = "Spara";
            btnSparaPodd.UseVisualStyleBackColor = true;
            btnSparaPodd.Click += btnSparaPodd_ClickAsync;
            // 
            // lstPoddar
            // 
            lstPoddar.FormattingEnabled = true;
            lstPoddar.Location = new Point(715, 60);
            lstPoddar.Margin = new Padding(2, 3, 2, 3);
            lstPoddar.Name = "lstPoddar";
            lstPoddar.Size = new Size(281, 264);
            lstPoddar.TabIndex = 5;
            lstPoddar.SelectedIndexChanged += lstPoddar_SelectedIndexChangedAsync;
            // 
            // btnLaddaPoddar
            // 
            btnLaddaPoddar.Location = new Point(715, 20);
            btnLaddaPoddar.Margin = new Padding(2, 3, 2, 3);
            btnLaddaPoddar.Name = "btnLaddaPoddar";
            btnLaddaPoddar.Size = new Size(280, 27);
            btnLaddaPoddar.TabIndex = 6;
            btnLaddaPoddar.Text = "Visa sparade poddar";
            btnLaddaPoddar.UseVisualStyleBackColor = true;
            btnLaddaPoddar.Click += btnLaddaPoddar_ClickAsync;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(883, 665);
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
            cmbKategori.Location = new Point(883, 689);
            cmbKategori.Margin = new Padding(3, 4, 3, 4);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(138, 28);
            cmbKategori.TabIndex = 8;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.Location = new Point(902, 529);
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
            btnTaBortKategori.Location = new Point(902, 568);
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
            btnLaggTillKategori.Location = new Point(902, 607);
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
            txtNyKategori.Location = new Point(1029, 608);
            txtNyKategori.Margin = new Padding(3, 4, 3, 4);
            txtNyKategori.Name = "txtNyKategori";
            txtNyKategori.Size = new Size(114, 27);
            txtNyKategori.TabIndex = 12;
            txtNyKategori.Text = "Ny kategori";
            txtNyKategori.TextChanged += txtNyKategori_TextChanged;
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(301, 339);
            txtTitel.Margin = new Padding(3, 4, 3, 4);
            txtTitel.Name = "txtTitel";
            txtTitel.ReadOnly = true;
            txtTitel.Size = new Size(273, 27);
            txtTitel.TabIndex = 13;
            // 
            // txtBeskrivning
            // 
            txtBeskrivning.Location = new Point(301, 393);
            txtBeskrivning.Margin = new Padding(3, 4, 3, 4);
            txtBeskrivning.Multiline = true;
            txtBeskrivning.Name = "txtBeskrivning";
            txtBeskrivning.ReadOnly = true;
            txtBeskrivning.ScrollBars = ScrollBars.Vertical;
            txtBeskrivning.Size = new Size(273, 123);
            txtBeskrivning.TabIndex = 14;
            // 
            // txtPubliceringsdatum
            // 
            txtPubliceringsdatum.Location = new Point(301, 531);
            txtPubliceringsdatum.Margin = new Padding(3, 4, 3, 4);
            txtPubliceringsdatum.Name = "txtPubliceringsdatum";
            txtPubliceringsdatum.ReadOnly = true;
            txtPubliceringsdatum.Size = new Size(273, 27);
            txtPubliceringsdatum.TabIndex = 15;
            // 
            // btnAvprenumerera
            // 
            btnAvprenumerera.Location = new Point(579, 20);
            btnAvprenumerera.Name = "btnAvprenumerera";
            btnAvprenumerera.Size = new Size(122, 29);
            btnAvprenumerera.TabIndex = 16;
            btnAvprenumerera.Text = "Avprenumerera";
            btnAvprenumerera.UseVisualStyleBackColor = true;
            btnAvprenumerera.Click += btnAvprenumerera_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 815);
            Controls.Add(btnAvprenumerera);
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
            Controls.Add(txtDetaljer);
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
        private TextBox txtDetaljer;
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
        private Button btnAvprenumerera;
    }
}
