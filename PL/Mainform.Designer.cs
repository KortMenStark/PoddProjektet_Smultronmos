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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            btnHamtaRss = new Button();
            txtRssUrl = new TextBox();
            btnSparaPodd = new Button();
            lstPoddar = new ListBox();
            btnLaddaPoddar = new Button();
            txtTitel = new TextBox();
            txtBeskrivning = new TextBox();
            cbmFilterKategori = new ComboBox();
            lblKategori = new Label();
            lblTitel = new Label();
            lblBeskrivning = new Label();
            btnAvprenumerera = new Button();
            txtAvsnittTitel = new TextBox();
            lblAvsnittTitel = new Label();
            txtKategori = new TextBox();
            lblAktuellkategori = new Label();
            cmbKategori = new ComboBox();
            btnAndraKategori = new Button();
            lblNyKategori = new Label();
            panelLeft = new Panel();
            lblRss = new Label();
            btnHanteraKategorier = new Button();
            panel1 = new Panel();
            lblPodcast = new Label();
            pictureBox1 = new PictureBox();
            txtPubliceringsdatum = new TextBox();
            lblUtgivningsdatum = new Label();
            lstAvsnitt = new ListBox();
            lblMinaPoddar = new Label();
            panelPoddLista = new Panel();
            lblPoddListaSeparator = new Label();
            panelAvsnittLista = new Panel();
            lblAvsnittSeparator = new Label();
            lblAvsnittRubrik = new Label();
            panelAvsnittDetaljer = new Panel();
            pbPoddBild = new PictureBox();
            panelLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPoddLista.SuspendLayout();
            panelAvsnittLista.SuspendLayout();
            panelAvsnittDetaljer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPoddBild).BeginInit();
            SuspendLayout();
            // 
            // btnHamtaRss
            // 
            btnHamtaRss.BackColor = Color.Transparent;
            btnHamtaRss.FlatAppearance.BorderSize = 0;
            btnHamtaRss.FlatStyle = FlatStyle.Flat;
            btnHamtaRss.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHamtaRss.ForeColor = Color.White;
            btnHamtaRss.Image = Properties.Resources.download_24;
            btnHamtaRss.Location = new Point(0, 714);
            btnHamtaRss.Margin = new Padding(2);
            btnHamtaRss.Name = "btnHamtaRss";
            btnHamtaRss.Size = new Size(190, 60);
            btnHamtaRss.TabIndex = 0;
            btnHamtaRss.Text = "Hämta RSS";
            btnHamtaRss.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHamtaRss.UseVisualStyleBackColor = false;
            btnHamtaRss.Click += btnHamtaRss_ClickAsync;
            // 
            // txtRssUrl
            // 
            txtRssUrl.BackColor = Color.White;
            txtRssUrl.BorderStyle = BorderStyle.FixedSingle;
            txtRssUrl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRssUrl.ForeColor = Color.Black;
            txtRssUrl.Location = new Point(3, 683);
            txtRssUrl.Margin = new Padding(2);
            txtRssUrl.Name = "txtRssUrl";
            txtRssUrl.Size = new Size(173, 34);
            txtRssUrl.TabIndex = 3;
            txtRssUrl.TextChanged += txtRssUrl_TextChanged;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.BackColor = Color.Transparent;
            btnSparaPodd.FlatAppearance.BorderSize = 0;
            btnSparaPodd.FlatStyle = FlatStyle.Flat;
            btnSparaPodd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSparaPodd.ForeColor = Color.White;
            btnSparaPodd.Image = Properties.Resources.diskette_save_24;
            btnSparaPodd.Location = new Point(0, 220);
            btnSparaPodd.Margin = new Padding(2);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(190, 60);
            btnSparaPodd.TabIndex = 4;
            btnSparaPodd.Text = "Spara";
            btnSparaPodd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSparaPodd.UseVisualStyleBackColor = false;
            btnSparaPodd.Click += btnSparaPodd_Click;
            // 
            // lstPoddar
            // 
            lstPoddar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstPoddar.BackColor = Color.White;
            lstPoddar.BorderStyle = BorderStyle.FixedSingle;
            lstPoddar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPoddar.ForeColor = Color.Black;
            lstPoddar.FormattingEnabled = true;
            lstPoddar.Location = new Point(10, 40);
            lstPoddar.Margin = new Padding(2);
            lstPoddar.Name = "lstPoddar";
            lstPoddar.Size = new Size(240, 338);
            lstPoddar.TabIndex = 5;
            lstPoddar.SelectedIndexChanged += lstPoddar_SelectedIndexChangedAsync;
            // 
            // btnLaddaPoddar
            // 
            btnLaddaPoddar.BackColor = Color.Transparent;
            btnLaddaPoddar.FlatAppearance.BorderSize = 0;
            btnLaddaPoddar.FlatStyle = FlatStyle.Flat;
            btnLaddaPoddar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLaddaPoddar.ForeColor = Color.White;
            btnLaddaPoddar.Image = Properties.Resources.icons8_load_24;
            btnLaddaPoddar.Location = new Point(0, 150);
            btnLaddaPoddar.Margin = new Padding(2);
            btnLaddaPoddar.Name = "btnLaddaPoddar";
            btnLaddaPoddar.Size = new Size(190, 60);
            btnLaddaPoddar.TabIndex = 6;
            btnLaddaPoddar.Text = "Mina poddar";
            btnLaddaPoddar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLaddaPoddar.UseVisualStyleBackColor = false;
            btnLaddaPoddar.Click += btnLaddaPoddar_ClickAsync;
            // 
            // txtTitel
            // 
            txtTitel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitel.BackColor = Color.White;
            txtTitel.BorderStyle = BorderStyle.FixedSingle;
            txtTitel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitel.ForeColor = Color.Black;
            txtTitel.Location = new Point(10, 30);
            txtTitel.Name = "txtTitel";
            txtTitel.ReadOnly = true;
            txtTitel.Size = new Size(360, 39);
            txtTitel.TabIndex = 13;
            // 
            // txtBeskrivning
            // 
            txtBeskrivning.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBeskrivning.BackColor = Color.White;
            txtBeskrivning.BorderStyle = BorderStyle.FixedSingle;
            txtBeskrivning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBeskrivning.ForeColor = Color.Black;
            txtBeskrivning.Location = new Point(10, 210);
            txtBeskrivning.Multiline = true;
            txtBeskrivning.Name = "txtBeskrivning";
            txtBeskrivning.ReadOnly = true;
            txtBeskrivning.ScrollBars = ScrollBars.Vertical;
            txtBeskrivning.Size = new Size(510, 450);
            txtBeskrivning.TabIndex = 14;
            // 
            // cbmFilterKategori
            // 
            cbmFilterKategori.FormattingEnabled = true;
            cbmFilterKategori.Location = new Point(3, 578);
            cbmFilterKategori.Name = "cbmFilterKategori";
            cbmFilterKategori.Size = new Size(173, 28);
            cbmFilterKategori.TabIndex = 16;
            cbmFilterKategori.SelectedIndexChanged += cbmFilterKategori_SelectedIndexChanged;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.BackColor = Color.Transparent;
            lblKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblKategori.ForeColor = Color.White;
            lblKategori.Location = new Point(3, 560);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(139, 23);
            lblKategori.TabIndex = 17;
            lblKategori.Text = "Mina kategorier";
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTitel.ForeColor = Color.Black;
            lblTitel.Location = new Point(10, 10);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(89, 23);
            lblTitel.TabIndex = 18;
            lblTitel.Text = "Podd titel";
            lblTitel.Click += lblTitel_Click;
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBeskrivning.ForeColor = Color.Black;
            lblBeskrivning.Location = new Point(10, 190);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(91, 20);
            lblBeskrivning.TabIndex = 19;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // btnAvprenumerera
            // 
            btnAvprenumerera.BackColor = Color.Transparent;
            btnAvprenumerera.FlatAppearance.BorderSize = 0;
            btnAvprenumerera.FlatStyle = FlatStyle.Flat;
            btnAvprenumerera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAvprenumerera.ForeColor = Color.White;
            btnAvprenumerera.Image = Properties.Resources.Unsub_24;
            btnAvprenumerera.Location = new Point(0, 360);
            btnAvprenumerera.Name = "btnAvprenumerera";
            btnAvprenumerera.Size = new Size(190, 60);
            btnAvprenumerera.TabIndex = 21;
            btnAvprenumerera.Text = "Avprenumerera";
            btnAvprenumerera.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAvprenumerera.UseVisualStyleBackColor = false;
            btnAvprenumerera.Click += btnAvprenumerera_ClickAsync;
            // 
            // txtAvsnittTitel
            // 
            txtAvsnittTitel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAvsnittTitel.BackColor = Color.White;
            txtAvsnittTitel.BorderStyle = BorderStyle.FixedSingle;
            txtAvsnittTitel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAvsnittTitel.ForeColor = Color.Black;
            txtAvsnittTitel.Location = new Point(10, 35);
            txtAvsnittTitel.Margin = new Padding(3, 2, 3, 2);
            txtAvsnittTitel.Name = "txtAvsnittTitel";
            txtAvsnittTitel.ReadOnly = true;
            txtAvsnittTitel.Size = new Size(510, 34);
            txtAvsnittTitel.TabIndex = 22;
            // 
            // lblAvsnittTitel
            // 
            lblAvsnittTitel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblAvsnittTitel.ForeColor = Color.Black;
            lblAvsnittTitel.Location = new Point(10, 5);
            lblAvsnittTitel.Name = "lblAvsnittTitel";
            lblAvsnittTitel.Size = new Size(510, 26);
            lblAvsnittTitel.TabIndex = 23;
            lblAvsnittTitel.Text = "Avsnittstitel";
            // 
            // txtKategori
            // 
            txtKategori.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKategori.BackColor = Color.White;
            txtKategori.BorderStyle = BorderStyle.FixedSingle;
            txtKategori.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKategori.ForeColor = Color.Black;
            txtKategori.Location = new Point(10, 90);
            txtKategori.Margin = new Padding(3, 2, 3, 2);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(510, 34);
            txtKategori.TabIndex = 24;
            // 
            // lblAktuellkategori
            // 
            lblAktuellkategori.AutoSize = true;
            lblAktuellkategori.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAktuellkategori.ForeColor = Color.Black;
            lblAktuellkategori.Location = new Point(10, 70);
            lblAktuellkategori.Name = "lblAktuellkategori";
            lblAktuellkategori.Size = new Size(69, 20);
            lblAktuellkategori.TabIndex = 25;
            lblAktuellkategori.Text = "Kategori";
            // 
            // cmbKategori
            // 
            cmbKategori.BackColor = Color.White;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(3, 516);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(173, 28);
            cmbKategori.TabIndex = 26;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.BackColor = Color.Transparent;
            btnAndraKategori.FlatAppearance.BorderSize = 0;
            btnAndraKategori.FlatStyle = FlatStyle.Flat;
            btnAndraKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAndraKategori.ForeColor = Color.White;
            btnAndraKategori.Image = Properties.Resources.edit_24;
            btnAndraKategori.Location = new Point(0, 430);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(190, 60);
            btnAndraKategori.TabIndex = 27;
            btnAndraKategori.Text = "Ändra Kategori";
            btnAndraKategori.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAndraKategori.UseVisualStyleBackColor = false;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // lblNyKategori
            // 
            lblNyKategori.AutoSize = true;
            lblNyKategori.BackColor = Color.Transparent;
            lblNyKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNyKategori.ForeColor = Color.White;
            lblNyKategori.Location = new Point(3, 496);
            lblNyKategori.Name = "lblNyKategori";
            lblNyKategori.Size = new Size(110, 23);
            lblNyKategori.TabIndex = 28;
            lblNyKategori.Text = "Ny kategori:";
            lblNyKategori.Click += lblNyKategori_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(55, 70, 95);
            panelLeft.Controls.Add(lblRss);
            panelLeft.Controls.Add(btnAndraKategori);
            panelLeft.Controls.Add(btnSparaPodd);
            panelLeft.Controls.Add(cmbKategori);
            panelLeft.Controls.Add(btnHanteraKategorier);
            panelLeft.Controls.Add(btnLaddaPoddar);
            panelLeft.Controls.Add(btnAvprenumerera);
            panelLeft.Controls.Add(lblNyKategori);
            panelLeft.Controls.Add(cbmFilterKategori);
            panelLeft.Controls.Add(lblKategori);
            panelLeft.Controls.Add(panel1);
            panelLeft.Controls.Add(txtRssUrl);
            panelLeft.Controls.Add(btnHamtaRss);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 811);
            panelLeft.TabIndex = 29;
            panelLeft.Paint += panelLeft_Paint;
            // 
            // lblRss
            // 
            lblRss.AutoSize = true;
            lblRss.BackColor = Color.Transparent;
            lblRss.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblRss.ForeColor = Color.White;
            lblRss.Location = new Point(3, 657);
            lblRss.Name = "lblRss";
            lblRss.Size = new Size(126, 23);
            lblRss.TabIndex = 29;
            lblRss.Text = "Klistra in länk:";
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.BackColor = Color.Transparent;
            btnHanteraKategorier.FlatAppearance.BorderSize = 0;
            btnHanteraKategorier.FlatStyle = FlatStyle.Flat;
            btnHanteraKategorier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHanteraKategorier.ForeColor = Color.White;
            btnHanteraKategorier.Image = Properties.Resources.icons8_folder_24;
            btnHanteraKategorier.Location = new Point(0, 290);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(190, 60);
            btnHanteraKategorier.TabIndex = 22;
            btnHanteraKategorier.Text = "Hantera kategorier";
            btnHanteraKategorier.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHanteraKategorier.UseVisualStyleBackColor = false;
            btnHanteraKategorier.Click += btnHanteraKategorier_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPodcast);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 140);
            panel1.TabIndex = 0;
            // 
            // lblPodcast
            // 
            lblPodcast.AutoSize = true;
            lblPodcast.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPodcast.ForeColor = Color.FromArgb(0, 125, 250);
            lblPodcast.Location = new Point(66, 115);
            lblPodcast.Name = "lblPodcast";
            lblPodcast.Size = new Size(81, 23);
            lblPodcast.TabIndex = 1;
            lblPodcast.Text = "PodVault";
            lblPodcast.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.headphone;
            pictureBox1.Location = new Point(50, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtPubliceringsdatum
            // 
            txtPubliceringsdatum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPubliceringsdatum.BackColor = Color.White;
            txtPubliceringsdatum.BorderStyle = BorderStyle.FixedSingle;
            txtPubliceringsdatum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPubliceringsdatum.ForeColor = Color.Black;
            txtPubliceringsdatum.Location = new Point(10, 150);
            txtPubliceringsdatum.Name = "txtPubliceringsdatum";
            txtPubliceringsdatum.ReadOnly = true;
            txtPubliceringsdatum.Size = new Size(510, 34);
            txtPubliceringsdatum.TabIndex = 15;
            // 
            // lblUtgivningsdatum
            // 
            lblUtgivningsdatum.AutoSize = true;
            lblUtgivningsdatum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUtgivningsdatum.ForeColor = Color.Black;
            lblUtgivningsdatum.Location = new Point(10, 130);
            lblUtgivningsdatum.Name = "lblUtgivningsdatum";
            lblUtgivningsdatum.Size = new Size(131, 20);
            lblUtgivningsdatum.TabIndex = 20;
            lblUtgivningsdatum.Text = "Utgivningsdatum";
            // 
            // lstAvsnitt
            // 
            lstAvsnitt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstAvsnitt.BackColor = Color.White;
            lstAvsnitt.BorderStyle = BorderStyle.FixedSingle;
            lstAvsnitt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstAvsnitt.ForeColor = Color.Black;
            lstAvsnitt.FormattingEnabled = true;
            lstAvsnitt.Location = new Point(10, 100);
            lstAvsnitt.Margin = new Padding(2);
            lstAvsnitt.Name = "lstAvsnitt";
            lstAvsnitt.Size = new Size(360, 562);
            lstAvsnitt.TabIndex = 1;
            lstAvsnitt.SelectedIndexChanged += lstAvsnitt_SelectedIndexChanged;
            // 
            // lblMinaPoddar
            // 
            lblMinaPoddar.AutoSize = true;
            lblMinaPoddar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinaPoddar.Location = new Point(10, 10);
            lblMinaPoddar.Name = "lblMinaPoddar";
            lblMinaPoddar.Size = new Size(161, 32);
            lblMinaPoddar.TabIndex = 30;
            lblMinaPoddar.Text = "Mina Poddar";
            // 
            // panelPoddLista
            // 
            panelPoddLista.BackColor = Color.White;
            panelPoddLista.BorderStyle = BorderStyle.FixedSingle;
            panelPoddLista.Controls.Add(pbPoddBild);
            panelPoddLista.Controls.Add(lblPoddListaSeparator);
            panelPoddLista.Controls.Add(lstPoddar);
            panelPoddLista.Controls.Add(lblMinaPoddar);
            panelPoddLista.Location = new Point(210, 80);
            panelPoddLista.Name = "panelPoddLista";
            panelPoddLista.Size = new Size(260, 700);
            panelPoddLista.TabIndex = 31;
            // 
            // lblPoddListaSeparator
            // 
            lblPoddListaSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPoddListaSeparator.BackColor = Color.LightGray;
            lblPoddListaSeparator.ForeColor = Color.LightGray;
            lblPoddListaSeparator.Location = new Point(10, 35);
            lblPoddListaSeparator.Name = "lblPoddListaSeparator";
            lblPoddListaSeparator.Size = new Size(240, 1);
            lblPoddListaSeparator.TabIndex = 31;
            lblPoddListaSeparator.Text = "hjj";
            // 
            // panelAvsnittLista
            // 
            panelAvsnittLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelAvsnittLista.BackColor = Color.White;
            panelAvsnittLista.BorderStyle = BorderStyle.FixedSingle;
            panelAvsnittLista.Controls.Add(lblAvsnittSeparator);
            panelAvsnittLista.Controls.Add(lblAvsnittRubrik);
            panelAvsnittLista.Controls.Add(lblTitel);
            panelAvsnittLista.Controls.Add(txtTitel);
            panelAvsnittLista.Controls.Add(lstAvsnitt);
            panelAvsnittLista.Location = new Point(480, 80);
            panelAvsnittLista.Name = "panelAvsnittLista";
            panelAvsnittLista.Size = new Size(380, 700);
            panelAvsnittLista.TabIndex = 32;
            panelAvsnittLista.Paint += panelAvsnittLista_Paint;
            // 
            // lblAvsnittSeparator
            // 
            lblAvsnittSeparator.BackColor = Color.LightGray;
            lblAvsnittSeparator.Location = new Point(10, 90);
            lblAvsnittSeparator.Name = "lblAvsnittSeparator";
            lblAvsnittSeparator.Size = new Size(360, 1);
            lblAvsnittSeparator.TabIndex = 20;
            // 
            // lblAvsnittRubrik
            // 
            lblAvsnittRubrik.AutoSize = true;
            lblAvsnittRubrik.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblAvsnittRubrik.Location = new Point(10, 70);
            lblAvsnittRubrik.Name = "lblAvsnittRubrik";
            lblAvsnittRubrik.Size = new Size(67, 23);
            lblAvsnittRubrik.TabIndex = 19;
            lblAvsnittRubrik.Text = "Avsnitt";
            // 
            // panelAvsnittDetaljer
            // 
            panelAvsnittDetaljer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelAvsnittDetaljer.BackColor = Color.White;
            panelAvsnittDetaljer.BorderStyle = BorderStyle.FixedSingle;
            panelAvsnittDetaljer.Controls.Add(lblAvsnittTitel);
            panelAvsnittDetaljer.Controls.Add(txtAvsnittTitel);
            panelAvsnittDetaljer.Controls.Add(txtKategori);
            panelAvsnittDetaljer.Controls.Add(lblAktuellkategori);
            panelAvsnittDetaljer.Controls.Add(txtPubliceringsdatum);
            panelAvsnittDetaljer.Controls.Add(lblBeskrivning);
            panelAvsnittDetaljer.Controls.Add(lblUtgivningsdatum);
            panelAvsnittDetaljer.Controls.Add(txtBeskrivning);
            panelAvsnittDetaljer.Location = new Point(870, 80);
            panelAvsnittDetaljer.Name = "panelAvsnittDetaljer";
            panelAvsnittDetaljer.Size = new Size(530, 700);
            panelAvsnittDetaljer.TabIndex = 21;
            // 
            // pbPoddBild
            // 
            pbPoddBild.Location = new Point(10, 420);
            pbPoddBild.Name = "pbPoddBild";
            pbPoddBild.Size = new Size(240, 216);
            pbPoddBild.TabIndex = 32;
            pbPoddBild.TabStop = false;
            pbPoddBild.Click += pictureBox2_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1434, 811);
            Controls.Add(panelAvsnittDetaljer);
            Controls.Add(panelAvsnittLista);
            Controls.Add(panelPoddLista);
            Controls.Add(panelLeft);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Mainform";
            Text = "PodVault";
            Load += Mainform_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPoddLista.ResumeLayout(false);
            panelPoddLista.PerformLayout();
            panelAvsnittLista.ResumeLayout(false);
            panelAvsnittLista.PerformLayout();
            panelAvsnittDetaljer.ResumeLayout(false);
            panelAvsnittDetaljer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPoddBild).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHamtaRss;
        private TextBox txtRssUrl;
        private Button btnSparaPodd;
        private ListBox lstPoddar;
        private Button btnLaddaPoddar;
        private TextBox txtTitel;
        private TextBox txtBeskrivning;
        private ComboBox cbmFilterKategori;
        private Label lblKategori;
        private Label lblTitel;
        private Label lblBeskrivning;
        private Button btnAvprenumerera;
        private TextBox txtAvsnittTitel;
        private Label lblAvsnittTitel;
        private TextBox txtKategori;
        private Label lblAktuellkategori;
        private ComboBox cmbKategori;
        private Button btnAndraKategori;
        private Label lblNyKategori;
        private Panel panelLeft;
        private Button btnHanteraKategorier;
        private TextBox txtPubliceringsdatum;
        private Label lblUtgivningsdatum;
        private Panel panel1;
        private Label lblPodcast;
        private PictureBox pictureBox1;
        private ListBox lstAvsnitt;
        private Label lblRss;
        private Label lblMinaPoddar;
        private Panel panelPoddLista;
        private Label lblPoddListaSeparator;
        private Panel panelAvsnittLista;
        private Label lblAvsnittSeparator;
        private Label lblAvsnittRubrik;
        private Panel panelAvsnittDetaljer;
        private PictureBox pbPoddBild;
    }
}
