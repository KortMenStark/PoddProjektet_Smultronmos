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
            cbmFilterKategori = new ComboBox();
            lblKategori = new Label();
            lblBeskrivning = new Label();
            btnAvprenumerera = new Button();
            txtAvsnittTitel = new TextBox();
            lblAktuellkategori = new Label();
            cmbKategori = new ComboBox();
            btnAndraKategori = new Button();
            lblNyKategori = new Label();
            panelMinaPoddar = new Panel();
            lblRss = new Label();
            lblMinaPoddar = new Label();
            btnHanteraKategorier = new Button();
            panelLogo = new Panel();
            lblPodcast = new Label();
            pBoxLogo = new PictureBox();
            txtPubliceringsdatum = new TextBox();
            lblUtgivningsdatum = new Label();
            lstAvsnitt = new ListBox();
            pbPoddBild = new PictureBox();
            panelAvsnittLista = new Panel();
            btnSkapaNyKategori = new Button();
            btnLaggTillNyKategori = new Button();
            btnSparaNyKategori = new Button();
            btnSparaPoddKategori = new Button();
            cmbPoddKategori = new ComboBox();
            lblAvsnittSeparator = new Label();
            lblAvsnittRubrik = new Label();
            panelAvsnittDetaljer = new Panel();
            txtBeskrivning = new RichTextBox();
            label1 = new Label();
            panelMinaPoddar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPoddBild).BeginInit();
            panelAvsnittLista.SuspendLayout();
            panelAvsnittDetaljer.SuspendLayout();
            SuspendLayout();
            // 
            // btnHamtaRss
            // 
            btnHamtaRss.BackColor = Color.White;
            btnHamtaRss.FlatAppearance.BorderSize = 0;
            btnHamtaRss.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHamtaRss.ForeColor = SystemColors.ControlText;
            btnHamtaRss.Image = Properties.Resources.search_16;
            btnHamtaRss.Location = new Point(174, 774);
            btnHamtaRss.Name = "btnHamtaRss";
            btnHamtaRss.Size = new Size(120, 25);
            btnHamtaRss.TabIndex = 0;
            btnHamtaRss.Text = "Sök";
            btnHamtaRss.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnHamtaRss.UseVisualStyleBackColor = true;
            btnHamtaRss.Click += btnHamtaRss_ClickAsync;
            // 
            // txtRssUrl
            // 
            txtRssUrl.BackColor = Color.White;
            txtRssUrl.BorderStyle = BorderStyle.FixedSingle;
            txtRssUrl.Cursor = Cursors.IBeam;
            txtRssUrl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRssUrl.ForeColor = Color.Black;
            txtRssUrl.Location = new Point(3, 774);
            txtRssUrl.Margin = new Padding(2);
            txtRssUrl.Name = "txtRssUrl";
            txtRssUrl.Size = new Size(169, 25);
            txtRssUrl.TabIndex = 3;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.BackColor = Color.Transparent;
            btnSparaPodd.FlatAppearance.BorderSize = 0;
            btnSparaPodd.FlatStyle = FlatStyle.Flat;
            btnSparaPodd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSparaPodd.ForeColor = Color.White;
            btnSparaPodd.Image = Properties.Resources.diskette_save_24;
            btnSparaPodd.ImageAlign = ContentAlignment.TopCenter;
            btnSparaPodd.Location = new Point(149, 159);
            btnSparaPodd.Margin = new Padding(2);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Padding = new Padding(10, 5, 10, 5);
            btnSparaPodd.Size = new Size(145, 68);
            btnSparaPodd.TabIndex = 4;
            btnSparaPodd.Text = "Spara";
            btnSparaPodd.TextAlign = ContentAlignment.BottomCenter;
            btnSparaPodd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSparaPodd.UseVisualStyleBackColor = false;
            btnSparaPodd.Click += btnSparaPodd_Click;
            // 
            // lstPoddar
            // 
            lstPoddar.BackColor = Color.White;
            lstPoddar.BorderStyle = BorderStyle.FixedSingle;
            lstPoddar.DrawMode = DrawMode.OwnerDrawFixed;
            lstPoddar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPoddar.ForeColor = Color.Black;
            lstPoddar.FormattingEnabled = true;
            lstPoddar.ItemHeight = 30;
            lstPoddar.Location = new Point(2, 468);
            lstPoddar.Margin = new Padding(2);
            lstPoddar.Name = "lstPoddar";
            lstPoddar.Size = new Size(295, 242);
            lstPoddar.TabIndex = 5;
            lstPoddar.DrawItem += lstPoddar_DrawItem;
            lstPoddar.SelectedIndexChanged += lstPoddar_SelectedIndexChangedAsync;
            // 
            // btnLaddaPoddar
            // 
            btnLaddaPoddar.BackColor = Color.Transparent;
            btnLaddaPoddar.FlatAppearance.BorderSize = 0;
            btnLaddaPoddar.FlatAppearance.MouseDownBackColor = Color.White;
            btnLaddaPoddar.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 53, 65);
            btnLaddaPoddar.FlatStyle = FlatStyle.Flat;
            btnLaddaPoddar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLaddaPoddar.ForeColor = Color.White;
            btnLaddaPoddar.Image = Properties.Resources.favorite_24;
            btnLaddaPoddar.ImageAlign = ContentAlignment.TopCenter;
            btnLaddaPoddar.Location = new Point(-2, 159);
            btnLaddaPoddar.Name = "btnLaddaPoddar";
            btnLaddaPoddar.Padding = new Padding(10, 5, 10, 5);
            btnLaddaPoddar.Size = new Size(145, 68);
            btnLaddaPoddar.TabIndex = 6;
            btnLaddaPoddar.Text = "Mina poddar";
            btnLaddaPoddar.TextAlign = ContentAlignment.BottomCenter;
            btnLaddaPoddar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLaddaPoddar.UseVisualStyleBackColor = false;
            btnLaddaPoddar.Click += btnLaddaPoddar_ClickAsync;
            // 
            // txtTitel
            // 
            txtTitel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitel.BackColor = Color.WhiteSmoke;
            txtTitel.BorderStyle = BorderStyle.None;
            txtTitel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitel.ForeColor = Color.Black;
            txtTitel.Location = new Point(396, 14);
            txtTitel.Multiline = true;
            txtTitel.Name = "txtTitel";
            txtTitel.ReadOnly = true;
            txtTitel.Size = new Size(450, 55);
            txtTitel.TabIndex = 13;
            // 
            // cbmFilterKategori
            // 
            cbmFilterKategori.FormattingEnabled = true;
            cbmFilterKategori.Location = new Point(3, 408);
            cbmFilterKategori.Name = "cbmFilterKategori";
            cbmFilterKategori.Size = new Size(291, 25);
            cbmFilterKategori.TabIndex = 16;
            cbmFilterKategori.SelectedIndexChanged += cbmFilterKategori_SelectedIndexChanged;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.BackColor = Color.Transparent;
            lblKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblKategori.ForeColor = Color.White;
            lblKategori.Location = new Point(3, 385);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(106, 17);
            lblKategori.TabIndex = 17;
            lblKategori.Text = "Mina kategorier";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeskrivning.ForeColor = Color.Black;
            lblBeskrivning.Location = new Point(10, 16);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(117, 25);
            lblBeskrivning.TabIndex = 19;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // btnAvprenumerera
            // 
            btnAvprenumerera.BackColor = Color.Transparent;
            btnAvprenumerera.FlatAppearance.BorderSize = 0;
            btnAvprenumerera.FlatAppearance.MouseDownBackColor = Color.White;
            btnAvprenumerera.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 53, 65);
            btnAvprenumerera.FlatStyle = FlatStyle.Flat;
            btnAvprenumerera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAvprenumerera.ForeColor = Color.White;
            btnAvprenumerera.Image = Properties.Resources.Unsub_24;
            btnAvprenumerera.ImageAlign = ContentAlignment.TopCenter;
            btnAvprenumerera.Location = new Point(149, 234);
            btnAvprenumerera.Name = "btnAvprenumerera";
            btnAvprenumerera.Padding = new Padding(10, 5, 10, 5);
            btnAvprenumerera.Size = new Size(145, 68);
            btnAvprenumerera.TabIndex = 21;
            btnAvprenumerera.Text = "Avprenumerera";
            btnAvprenumerera.TextAlign = ContentAlignment.BottomCenter;
            btnAvprenumerera.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAvprenumerera.UseVisualStyleBackColor = false;
            btnAvprenumerera.Click += btnAvprenumerera_ClickAsync;
            // 
            // txtAvsnittTitel
            // 
            txtAvsnittTitel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAvsnittTitel.BackColor = Color.WhiteSmoke;
            txtAvsnittTitel.BorderStyle = BorderStyle.None;
            txtAvsnittTitel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAvsnittTitel.ForeColor = Color.Black;
            txtAvsnittTitel.Location = new Point(903, 14);
            txtAvsnittTitel.Multiline = true;
            txtAvsnittTitel.Name = "txtAvsnittTitel";
            txtAvsnittTitel.ReadOnly = true;
            txtAvsnittTitel.Size = new Size(450, 55);
            txtAvsnittTitel.TabIndex = 22;
            // 
            // lblAktuellkategori
            // 
            lblAktuellkategori.AutoSize = true;
            lblAktuellkategori.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAktuellkategori.ForeColor = Color.Black;
            lblAktuellkategori.Location = new Point(10, 359);
            lblAktuellkategori.Name = "lblAktuellkategori";
            lblAktuellkategori.Size = new Size(55, 15);
            lblAktuellkategori.TabIndex = 25;
            lblAktuellkategori.Text = "Kategori";
            // 
            // cmbKategori
            // 
            cmbKategori.BackColor = Color.White;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(3, 866);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(173, 25);
            cmbKategori.TabIndex = 26;
            cmbKategori.Visible = false;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.BackColor = Color.Transparent;
            btnAndraKategori.FlatAppearance.BorderSize = 0;
            btnAndraKategori.FlatAppearance.MouseDownBackColor = Color.White;
            btnAndraKategori.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 53, 65);
            btnAndraKategori.FlatStyle = FlatStyle.Flat;
            btnAndraKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAndraKategori.ForeColor = Color.White;
            btnAndraKategori.Image = Properties.Resources.edit_24;
            btnAndraKategori.ImageAlign = ContentAlignment.TopCenter;
            btnAndraKategori.Location = new Point(-2, 314);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Padding = new Padding(10, 5, 10, 5);
            btnAndraKategori.Size = new Size(145, 68);
            btnAndraKategori.TabIndex = 27;
            btnAndraKategori.Text = "Ändra Kategori";
            btnAndraKategori.TextAlign = ContentAlignment.BottomCenter;
            btnAndraKategori.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAndraKategori.UseVisualStyleBackColor = false;
            btnAndraKategori.Visible = false;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // lblNyKategori
            // 
            lblNyKategori.AutoSize = true;
            lblNyKategori.BackColor = Color.Transparent;
            lblNyKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNyKategori.ForeColor = Color.White;
            lblNyKategori.Location = new Point(3, 843);
            lblNyKategori.Name = "lblNyKategori";
            lblNyKategori.Size = new Size(84, 17);
            lblNyKategori.TabIndex = 28;
            lblNyKategori.Text = "Ny kategori:";
            lblNyKategori.Visible = false;
            // 
            // panelMinaPoddar
            // 
            panelMinaPoddar.BackColor = Color.FromArgb(66, 111, 175);
            panelMinaPoddar.Controls.Add(lblRss);
            panelMinaPoddar.Controls.Add(lblMinaPoddar);
            panelMinaPoddar.Controls.Add(btnAndraKategori);
            panelMinaPoddar.Controls.Add(lstPoddar);
            panelMinaPoddar.Controls.Add(btnSparaPodd);
            panelMinaPoddar.Controls.Add(cmbKategori);
            panelMinaPoddar.Controls.Add(btnHanteraKategorier);
            panelMinaPoddar.Controls.Add(btnLaddaPoddar);
            panelMinaPoddar.Controls.Add(btnAvprenumerera);
            panelMinaPoddar.Controls.Add(lblNyKategori);
            panelMinaPoddar.Controls.Add(btnHamtaRss);
            panelMinaPoddar.Controls.Add(cbmFilterKategori);
            panelMinaPoddar.Controls.Add(lblKategori);
            panelMinaPoddar.Controls.Add(panelLogo);
            panelMinaPoddar.Controls.Add(txtRssUrl);
            panelMinaPoddar.Dock = DockStyle.Left;
            panelMinaPoddar.Location = new Point(0, 0);
            panelMinaPoddar.MaximumSize = new Size(300, 0);
            panelMinaPoddar.Name = "panelMinaPoddar";
            panelMinaPoddar.Size = new Size(300, 919);
            panelMinaPoddar.TabIndex = 29;
            // 
            // lblRss
            // 
            lblRss.AutoSize = true;
            lblRss.BackColor = Color.Transparent;
            lblRss.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblRss.ForeColor = Color.White;
            lblRss.Location = new Point(3, 755);
            lblRss.Name = "lblRss";
            lblRss.Size = new Size(70, 17);
            lblRss.TabIndex = 29;
            lblRss.Text = "Sök podd:";
            // 
            // lblMinaPoddar
            // 
            lblMinaPoddar.AutoSize = true;
            lblMinaPoddar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinaPoddar.ForeColor = Color.White;
            lblMinaPoddar.Location = new Point(2, 437);
            lblMinaPoddar.Name = "lblMinaPoddar";
            lblMinaPoddar.Size = new Size(127, 25);
            lblMinaPoddar.TabIndex = 30;
            lblMinaPoddar.Text = "Mina Poddar";
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.BackColor = Color.Transparent;
            btnHanteraKategorier.FlatAppearance.BorderSize = 0;
            btnHanteraKategorier.FlatAppearance.MouseDownBackColor = Color.White;
            btnHanteraKategorier.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 53, 65);
            btnHanteraKategorier.FlatStyle = FlatStyle.Flat;
            btnHanteraKategorier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHanteraKategorier.ForeColor = Color.White;
            btnHanteraKategorier.Image = Properties.Resources.icons8_folder_24;
            btnHanteraKategorier.ImageAlign = ContentAlignment.TopCenter;
            btnHanteraKategorier.Location = new Point(-2, 234);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Padding = new Padding(10, 5, 10, 5);
            btnHanteraKategorier.Size = new Size(145, 68);
            btnHanteraKategorier.TabIndex = 22;
            btnHanteraKategorier.Text = "Hantera kategorier";
            btnHanteraKategorier.TextAlign = ContentAlignment.BottomCenter;
            btnHanteraKategorier.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHanteraKategorier.UseVisualStyleBackColor = false;
            btnHanteraKategorier.Click += btnHanteraKategorier_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(66, 111, 175);
            panelLogo.Controls.Add(lblPodcast);
            panelLogo.Controls.Add(pBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(300, 159);
            panelLogo.TabIndex = 0;
            // 
            // lblPodcast
            // 
            lblPodcast.AutoSize = true;
            lblPodcast.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPodcast.ForeColor = Color.White;
            lblPodcast.Location = new Point(112, 130);
            lblPodcast.Name = "lblPodcast";
            lblPodcast.Size = new Size(64, 17);
            lblPodcast.TabIndex = 1;
            lblPodcast.Text = "PodVault";
            lblPodcast.TextAlign = ContentAlignment.TopCenter;
            // 
            // pBoxLogo
            // 
            pBoxLogo.Image = Properties.Resources.headphone;
            pBoxLogo.Location = new Point(97, 14);
            pBoxLogo.Name = "pBoxLogo";
            pBoxLogo.Size = new Size(100, 113);
            pBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxLogo.TabIndex = 0;
            pBoxLogo.TabStop = false;
            // 
            // txtPubliceringsdatum
            // 
            txtPubliceringsdatum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPubliceringsdatum.BackColor = Color.White;
            txtPubliceringsdatum.BorderStyle = BorderStyle.None;
            txtPubliceringsdatum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPubliceringsdatum.ForeColor = Color.Black;
            txtPubliceringsdatum.Location = new Point(10, 745);
            txtPubliceringsdatum.Name = "txtPubliceringsdatum";
            txtPubliceringsdatum.ReadOnly = true;
            txtPubliceringsdatum.Size = new Size(428, 22);
            txtPubliceringsdatum.TabIndex = 15;
            // 
            // lblUtgivningsdatum
            // 
            lblUtgivningsdatum.AutoSize = true;
            lblUtgivningsdatum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUtgivningsdatum.ForeColor = Color.Black;
            lblUtgivningsdatum.Location = new Point(10, 724);
            lblUtgivningsdatum.Name = "lblUtgivningsdatum";
            lblUtgivningsdatum.Size = new Size(103, 15);
            lblUtgivningsdatum.TabIndex = 20;
            lblUtgivningsdatum.Text = "Utgivningsdatum";
            // 
            // lstAvsnitt
            // 
            lstAvsnitt.BackColor = Color.White;
            lstAvsnitt.BorderStyle = BorderStyle.FixedSingle;
            lstAvsnitt.DrawMode = DrawMode.OwnerDrawFixed;
            lstAvsnitt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstAvsnitt.ForeColor = Color.Black;
            lstAvsnitt.FormattingEnabled = true;
            lstAvsnitt.HorizontalScrollbar = true;
            lstAvsnitt.ItemHeight = 30;
            lstAvsnitt.Location = new Point(10, 442);
            lstAvsnitt.Margin = new Padding(2);
            lstAvsnitt.Name = "lstAvsnitt";
            lstAvsnitt.Size = new Size(415, 302);
            lstAvsnitt.TabIndex = 1;
            lstAvsnitt.DrawItem += lstAvsnitt_DrawItem;
            lstAvsnitt.SelectedIndexChanged += lstAvsnitt_SelectedIndexChanged;
            // 
            // pbPoddBild
            // 
            pbPoddBild.Location = new Point(98, 45);
            pbPoddBild.Name = "pbPoddBild";
            pbPoddBild.Size = new Size(240, 245);
            pbPoddBild.TabIndex = 32;
            pbPoddBild.TabStop = false;
            // 
            // panelAvsnittLista
            // 
            panelAvsnittLista.BackColor = Color.White;
            panelAvsnittLista.BorderStyle = BorderStyle.Fixed3D;
            panelAvsnittLista.Controls.Add(btnSkapaNyKategori);
            panelAvsnittLista.Controls.Add(btnLaggTillNyKategori);
            panelAvsnittLista.Controls.Add(btnSparaNyKategori);
            panelAvsnittLista.Controls.Add(btnSparaPoddKategori);
            panelAvsnittLista.Controls.Add(cmbPoddKategori);
            panelAvsnittLista.Controls.Add(pbPoddBild);
            panelAvsnittLista.Controls.Add(lblAvsnittSeparator);
            panelAvsnittLista.Controls.Add(lblAktuellkategori);
            panelAvsnittLista.Controls.Add(lblAvsnittRubrik);
            panelAvsnittLista.Controls.Add(lstAvsnitt);
            panelAvsnittLista.Location = new Point(396, 84);
            panelAvsnittLista.Name = "panelAvsnittLista";
            panelAvsnittLista.Size = new Size(450, 800);
            panelAvsnittLista.TabIndex = 32;
            // 
            // btnSkapaNyKategori
            // 
            btnSkapaNyKategori.Location = new Point(295, 377);
            btnSkapaNyKategori.Name = "btnSkapaNyKategori";
            btnSkapaNyKategori.Size = new Size(125, 25);
            btnSkapaNyKategori.TabIndex = 35;
            btnSkapaNyKategori.Text = "Skapa ny kategori";
            btnSkapaNyKategori.UseVisualStyleBackColor = true;
            btnSkapaNyKategori.Click += btnLaggTillNyKategori_Click;
            // 
            // btnLaggTillNyKategori
            // 
            btnLaggTillNyKategori.Location = new Point(295, 377);
            btnLaggTillNyKategori.Name = "btnLaggTillNyKategori";
            btnLaggTillNyKategori.Size = new Size(125, 26);
            btnLaggTillNyKategori.TabIndex = 35;
            btnLaggTillNyKategori.Text = "Skapa ny kategori";
            btnLaggTillNyKategori.UseVisualStyleBackColor = true;
            btnLaggTillNyKategori.Click += btnLaggTillNyKategori_Click;
            // 
            // btnSparaNyKategori
            // 
            btnSparaNyKategori.Location = new Point(174, 377);
            btnSparaNyKategori.Name = "btnSparaNyKategori";
            btnSparaNyKategori.Size = new Size(115, 25);
            btnSparaNyKategori.TabIndex = 34;
            btnSparaNyKategori.Text = "Spara ny Kategori";
            btnSparaNyKategori.UseVisualStyleBackColor = true;
            btnSparaNyKategori.Click += btnSparaPoddKategori_Click;
            // 
            // btnSparaPoddKategori
            // 
            btnSparaPoddKategori.Location = new Point(174, 377);
            btnSparaPoddKategori.Name = "btnSparaPoddKategori";
            btnSparaPoddKategori.Size = new Size(115, 26);
            btnSparaPoddKategori.TabIndex = 34;
            btnSparaPoddKategori.Text = "Spara ny Kategori";
            btnSparaPoddKategori.UseVisualStyleBackColor = true;
            btnSparaPoddKategori.Click += btnSparaPoddKategori_Click;
            // 
            // cmbPoddKategori
            // 
            cmbPoddKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPoddKategori.FormattingEnabled = true;
            cmbPoddKategori.Location = new Point(10, 379);
            cmbPoddKategori.Name = "cmbPoddKategori";
            cmbPoddKategori.Size = new Size(158, 25);
            cmbPoddKategori.TabIndex = 33;
            cmbPoddKategori.SelectedIndexChanged += cmbPoddKategori_SelectedIndexChanged;
            // 
            // lblAvsnittSeparator
            // 
            lblAvsnittSeparator.BackColor = Color.LightGray;
            lblAvsnittSeparator.Location = new Point(10, 408);
            lblAvsnittSeparator.Name = "lblAvsnittSeparator";
            lblAvsnittSeparator.Size = new Size(410, 1);
            lblAvsnittSeparator.TabIndex = 20;
            // 
            // lblAvsnittRubrik
            // 
            lblAvsnittRubrik.AutoSize = true;
            lblAvsnittRubrik.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblAvsnittRubrik.Location = new Point(10, 423);
            lblAvsnittRubrik.Name = "lblAvsnittRubrik";
            lblAvsnittRubrik.Size = new Size(52, 17);
            lblAvsnittRubrik.TabIndex = 19;
            lblAvsnittRubrik.Text = "Avsnitt";
            // 
            // panelAvsnittDetaljer
            // 
            panelAvsnittDetaljer.BackColor = Color.White;
            panelAvsnittDetaljer.BorderStyle = BorderStyle.Fixed3D;
            panelAvsnittDetaljer.Controls.Add(txtBeskrivning);
            panelAvsnittDetaljer.Controls.Add(label1);
            panelAvsnittDetaljer.Controls.Add(txtPubliceringsdatum);
            panelAvsnittDetaljer.Controls.Add(lblBeskrivning);
            panelAvsnittDetaljer.Controls.Add(lblUtgivningsdatum);
            panelAvsnittDetaljer.Location = new Point(903, 84);
            panelAvsnittDetaljer.Name = "panelAvsnittDetaljer";
            panelAvsnittDetaljer.Size = new Size(450, 800);
            panelAvsnittDetaljer.TabIndex = 21;
            // 
            // txtBeskrivning
            // 
            txtBeskrivning.BackColor = Color.WhiteSmoke;
            txtBeskrivning.BorderStyle = BorderStyle.FixedSingle;
            txtBeskrivning.DetectUrls = false;
            txtBeskrivning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBeskrivning.ForeColor = Color.FromArgb(30, 30, 30);
            txtBeskrivning.Location = new Point(10, 73);
            txtBeskrivning.Name = "txtBeskrivning";
            txtBeskrivning.ReadOnly = true;
            txtBeskrivning.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtBeskrivning.Size = new Size(420, 640);
            txtBeskrivning.TabIndex = 33;
            txtBeskrivning.Text = "";
            // 
            // label1
            // 
            label1.BackColor = Color.LightGray;
            label1.Location = new Point(10, 48);
            label1.Name = "label1";
            label1.Size = new Size(420, 1);
            label1.TabIndex = 33;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1434, 919);
            Controls.Add(txtAvsnittTitel);
            Controls.Add(panelAvsnittDetaljer);
            Controls.Add(panelAvsnittLista);
            Controls.Add(panelMinaPoddar);
            Controls.Add(txtTitel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimizeBox = false;
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PodVault";
            Load += Mainform_Load;
            panelMinaPoddar.ResumeLayout(false);
            panelMinaPoddar.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPoddBild).EndInit();
            panelAvsnittLista.ResumeLayout(false);
            panelAvsnittLista.PerformLayout();
            panelAvsnittDetaljer.ResumeLayout(false);
            panelAvsnittDetaljer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHamtaRss;
        private TextBox txtRssUrl;
        private Button btnSparaPodd;
        private ListBox lstPoddar;
        private Button btnLaddaPoddar;
        private TextBox txtTitel;
        private ComboBox cbmFilterKategori;
        private Label lblKategori;
        private Label lblBeskrivning;
        private Button btnAvprenumerera;
        private TextBox txtAvsnittTitel;
        private Label lblAktuellkategori;
        private ComboBox cmbKategori;
        private Button btnAndraKategori;
        private Label lblNyKategori;
        private Panel panelMinaPoddar;
        private Button btnHanteraKategorier;
        private TextBox txtPubliceringsdatum;
        private Label lblUtgivningsdatum;
        private Panel panelLogo;
        private Label lblPodcast;
        private PictureBox pBoxLogo;
        private ListBox lstAvsnitt;
        private Label lblRss;
        private Label lblMinaPoddar;
        private Panel panelAvsnittLista;
        private Label lblAvsnittSeparator;
        private Label lblAvsnittRubrik;
        private Panel panelAvsnittDetaljer;
        private PictureBox pbPoddBild;
        private Label label1;
        private Button btnLaggTillNyKategori;
        private Button btnSparaPoddKategori;
        private ComboBox cmbPoddKategori;
        private Button btnSkapaNyKategori;
        private Button btnSparaNyKategori;
        private RichTextBox txtBeskrivning;
    }
}
