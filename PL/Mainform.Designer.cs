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
            lblBeskrivning = new Label();
            btnAvprenumerera = new Button();
            txtAvsnittTitel = new TextBox();
            txtKategori = new TextBox();
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
            pictureBox1 = new PictureBox();
            txtPubliceringsdatum = new TextBox();
            lblUtgivningsdatum = new Label();
            lstAvsnitt = new ListBox();
            pbPoddBild = new PictureBox();
            panelAvsnittLista = new Panel();
            lblAvsnittSeparator = new Label();
            lblAvsnittRubrik = new Label();
            panelAvsnittDetaljer = new Panel();
            label1 = new Label();
            panelMinaPoddar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPoddBild).BeginInit();
            panelAvsnittLista.SuspendLayout();
            panelAvsnittDetaljer.SuspendLayout();
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
            btnHamtaRss.Location = new Point(180, 683);
            btnHamtaRss.Margin = new Padding(2);
            btnHamtaRss.Name = "btnHamtaRss";
            btnHamtaRss.Size = new Size(120, 29);
            btnHamtaRss.TabIndex = 0;
            btnHamtaRss.Text = "Sök";
            btnHamtaRss.TextImageRelation = TextImageRelation.TextBeforeImage;
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
            txtRssUrl.Size = new Size(173, 29);
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
            btnSparaPodd.Location = new Point(149, 140);
            btnSparaPodd.Margin = new Padding(2);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(145, 60);
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
            lstPoddar.Location = new Point(2, 413);
            lstPoddar.Margin = new Padding(2);
            lstPoddar.Name = "lstPoddar";
            lstPoddar.Size = new Size(295, 233);
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
            btnLaddaPoddar.Location = new Point(0, 140);
            btnLaddaPoddar.Margin = new Padding(2);
            btnLaddaPoddar.Name = "btnLaddaPoddar";
            btnLaddaPoddar.Size = new Size(145, 60);
            btnLaddaPoddar.TabIndex = 6;
            btnLaddaPoddar.Text = "Mina poddar";
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
            txtTitel.Location = new Point(407, 25);
            txtTitel.Multiline = true;
            txtTitel.Name = "txtTitel";
            txtTitel.ReadOnly = true;
            txtTitel.Size = new Size(417, 28);
            txtTitel.TabIndex = 13;
            // 
            // txtBeskrivning
            // 
            txtBeskrivning.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBeskrivning.BackColor = Color.White;
            txtBeskrivning.BorderStyle = BorderStyle.FixedSingle;
            txtBeskrivning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBeskrivning.ForeColor = Color.Black;
            txtBeskrivning.Location = new Point(10, 57);
            txtBeskrivning.Multiline = true;
            txtBeskrivning.Name = "txtBeskrivning";
            txtBeskrivning.ReadOnly = true;
            txtBeskrivning.ScrollBars = ScrollBars.Vertical;
            txtBeskrivning.Size = new Size(467, 571);
            txtBeskrivning.TabIndex = 14;
            // 
            // cbmFilterKategori
            // 
            cbmFilterKategori.FormattingEnabled = true;
            cbmFilterKategori.Location = new Point(3, 360);
            cbmFilterKategori.Name = "cbmFilterKategori";
            cbmFilterKategori.Size = new Size(291, 23);
            cbmFilterKategori.TabIndex = 16;
            cbmFilterKategori.SelectedIndexChanged += cbmFilterKategori_SelectedIndexChanged;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.BackColor = Color.Transparent;
            lblKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblKategori.ForeColor = Color.White;
            lblKategori.Location = new Point(3, 340);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(106, 17);
            lblKategori.TabIndex = 17;
            lblKategori.Text = "Mina kategorier";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBeskrivning.ForeColor = Color.Black;
            lblBeskrivning.Location = new Point(10, 22);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(73, 15);
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
            btnAvprenumerera.Location = new Point(149, 194);
            btnAvprenumerera.Name = "btnAvprenumerera";
            btnAvprenumerera.Size = new Size(145, 60);
            btnAvprenumerera.TabIndex = 21;
            btnAvprenumerera.Text = "Avprenumerera";
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
            txtAvsnittTitel.Location = new Point(914, 25);
            txtAvsnittTitel.Margin = new Padding(3, 2, 3, 2);
            txtAvsnittTitel.Name = "txtAvsnittTitel";
            txtAvsnittTitel.ReadOnly = true;
            txtAvsnittTitel.Size = new Size(467, 28);
            txtAvsnittTitel.TabIndex = 22;
            // 
            // txtKategori
            // 
            txtKategori.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKategori.BackColor = Color.White;
            txtKategori.BorderStyle = BorderStyle.FixedSingle;
            txtKategori.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKategori.ForeColor = Color.Black;
            txtKategori.Location = new Point(10, 323);
            txtKategori.Margin = new Padding(3, 2, 3, 2);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(417, 29);
            txtKategori.TabIndex = 24;
            // 
            // lblAktuellkategori
            // 
            lblAktuellkategori.AutoSize = true;
            lblAktuellkategori.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAktuellkategori.ForeColor = Color.Black;
            lblAktuellkategori.Location = new Point(10, 306);
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
            cmbKategori.Location = new Point(3, 764);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(173, 23);
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
            btnAndraKategori.Location = new Point(3, 253);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(145, 60);
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
            lblNyKategori.Location = new Point(3, 744);
            lblNyKategori.Name = "lblNyKategori";
            lblNyKategori.Size = new Size(84, 17);
            lblNyKategori.TabIndex = 28;
            lblNyKategori.Text = "Ny kategori:";
            // 
            // panelMinaPoddar
            // 
            panelMinaPoddar.BackColor = Color.FromArgb(55, 70, 95);
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
            panelMinaPoddar.Controls.Add(cbmFilterKategori);
            panelMinaPoddar.Controls.Add(lblKategori);
            panelMinaPoddar.Controls.Add(panelLogo);
            panelMinaPoddar.Controls.Add(txtRssUrl);
            panelMinaPoddar.Controls.Add(btnHamtaRss);
            panelMinaPoddar.Dock = DockStyle.Left;
            panelMinaPoddar.Location = new Point(0, 0);
            panelMinaPoddar.Name = "panelMinaPoddar";
            panelMinaPoddar.Size = new Size(300, 811);
            panelMinaPoddar.TabIndex = 29;
            panelMinaPoddar.Paint += panelLeft_Paint;
            // 
            // lblRss
            // 
            lblRss.AutoSize = true;
            lblRss.BackColor = Color.Transparent;
            lblRss.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblRss.ForeColor = Color.White;
            lblRss.Location = new Point(3, 657);
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
            lblMinaPoddar.Location = new Point(2, 386);
            lblMinaPoddar.Name = "lblMinaPoddar";
            lblMinaPoddar.Size = new Size(127, 25);
            lblMinaPoddar.TabIndex = 30;
            lblMinaPoddar.Text = "Mina Poddar";
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.BackColor = Color.Transparent;
            btnHanteraKategorier.FlatAppearance.BorderSize = 0;
            btnHanteraKategorier.FlatStyle = FlatStyle.Flat;
            btnHanteraKategorier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHanteraKategorier.ForeColor = Color.White;
            btnHanteraKategorier.Image = Properties.Resources.icons8_folder_24;
            btnHanteraKategorier.Location = new Point(0, 187);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(145, 60);
            btnHanteraKategorier.TabIndex = 22;
            btnHanteraKategorier.Text = "Hantera kategorier";
            btnHanteraKategorier.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHanteraKategorier.UseVisualStyleBackColor = false;
            btnHanteraKategorier.Click += btnHanteraKategorier_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblPodcast);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(300, 140);
            panelLogo.TabIndex = 0;
            // 
            // lblPodcast
            // 
            lblPodcast.AutoSize = true;
            lblPodcast.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPodcast.ForeColor = Color.FromArgb(0, 125, 250);
            lblPodcast.Location = new Point(112, 115);
            lblPodcast.Name = "lblPodcast";
            lblPodcast.Size = new Size(64, 17);
            lblPodcast.TabIndex = 1;
            lblPodcast.Text = "PodVault";
            lblPodcast.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.headphone;
            pictureBox1.Location = new Point(97, 12);
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
            txtPubliceringsdatum.BorderStyle = BorderStyle.None;
            txtPubliceringsdatum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPubliceringsdatum.ForeColor = Color.Black;
            txtPubliceringsdatum.Location = new Point(10, 657);
            txtPubliceringsdatum.Name = "txtPubliceringsdatum";
            txtPubliceringsdatum.ReadOnly = true;
            txtPubliceringsdatum.Size = new Size(467, 22);
            txtPubliceringsdatum.TabIndex = 15;
            // 
            // lblUtgivningsdatum
            // 
            lblUtgivningsdatum.AutoSize = true;
            lblUtgivningsdatum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUtgivningsdatum.ForeColor = Color.Black;
            lblUtgivningsdatum.Location = new Point(10, 639);
            lblUtgivningsdatum.Name = "lblUtgivningsdatum";
            lblUtgivningsdatum.Size = new Size(103, 15);
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
            lstAvsnitt.Location = new Point(10, 390);
            lstAvsnitt.Margin = new Padding(2);
            lstAvsnitt.Name = "lstAvsnitt";
            lstAvsnitt.Size = new Size(417, 296);
            lstAvsnitt.TabIndex = 1;
            lstAvsnitt.SelectedIndexChanged += lstAvsnitt_SelectedIndexChanged;
            // 
            // pbPoddBild
            // 
            pbPoddBild.Location = new Point(98, 40);
            pbPoddBild.Name = "pbPoddBild";
            pbPoddBild.Size = new Size(240, 216);
            pbPoddBild.TabIndex = 32;
            pbPoddBild.TabStop = false;
            pbPoddBild.Click += pictureBox2_Click;
            // 
            // panelAvsnittLista
            // 
            panelAvsnittLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelAvsnittLista.BackColor = Color.White;
            panelAvsnittLista.BorderStyle = BorderStyle.FixedSingle;
            panelAvsnittLista.Controls.Add(pbPoddBild);
            panelAvsnittLista.Controls.Add(lblAvsnittSeparator);
            panelAvsnittLista.Controls.Add(lblAktuellkategori);
            panelAvsnittLista.Controls.Add(txtKategori);
            panelAvsnittLista.Controls.Add(lblAvsnittRubrik);
            panelAvsnittLista.Controls.Add(lstAvsnitt);
            panelAvsnittLista.Location = new Point(396, 74);
            panelAvsnittLista.Name = "panelAvsnittLista";
            panelAvsnittLista.Size = new Size(437, 700);
            panelAvsnittLista.TabIndex = 32;
            panelAvsnittLista.Paint += panelAvsnittLista_Paint;
            // 
            // lblAvsnittSeparator
            // 
            lblAvsnittSeparator.BackColor = Color.LightGray;
            lblAvsnittSeparator.Location = new Point(10, 360);
            lblAvsnittSeparator.Name = "lblAvsnittSeparator";
            lblAvsnittSeparator.Size = new Size(410, 1);
            lblAvsnittSeparator.TabIndex = 20;
            // 
            // lblAvsnittRubrik
            // 
            lblAvsnittRubrik.AutoSize = true;
            lblAvsnittRubrik.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblAvsnittRubrik.Location = new Point(10, 361);
            lblAvsnittRubrik.Name = "lblAvsnittRubrik";
            lblAvsnittRubrik.Size = new Size(52, 17);
            lblAvsnittRubrik.TabIndex = 19;
            lblAvsnittRubrik.Text = "Avsnitt";
            // 
            // panelAvsnittDetaljer
            // 
            panelAvsnittDetaljer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelAvsnittDetaljer.BackColor = Color.White;
            panelAvsnittDetaljer.BorderStyle = BorderStyle.FixedSingle;
            panelAvsnittDetaljer.Controls.Add(label1);
            panelAvsnittDetaljer.Controls.Add(txtPubliceringsdatum);
            panelAvsnittDetaljer.Controls.Add(lblBeskrivning);
            panelAvsnittDetaljer.Controls.Add(lblUtgivningsdatum);
            panelAvsnittDetaljer.Controls.Add(txtBeskrivning);
            panelAvsnittDetaljer.Location = new Point(903, 74);
            panelAvsnittDetaljer.Name = "panelAvsnittDetaljer";
            panelAvsnittDetaljer.Size = new Size(487, 700);
            panelAvsnittDetaljer.TabIndex = 21;
            panelAvsnittDetaljer.Paint += panelAvsnittDetaljer_Paint;
            // 
            // label1
            // 
            label1.BackColor = Color.LightGray;
            label1.Location = new Point(10, 42);
            label1.Name = "label1";
            label1.Size = new Size(450, 1);
            label1.TabIndex = 33;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1434, 811);
            Controls.Add(txtAvsnittTitel);
            Controls.Add(panelAvsnittDetaljer);
            Controls.Add(panelAvsnittLista);
            Controls.Add(panelMinaPoddar);
            Controls.Add(txtTitel);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Mainform";
            Text = "PodVault";
            Load += Mainform_Load;
            panelMinaPoddar.ResumeLayout(false);
            panelMinaPoddar.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox txtBeskrivning;
        private ComboBox cbmFilterKategori;
        private Label lblKategori;
        private Label lblBeskrivning;
        private Button btnAvprenumerera;
        private TextBox txtAvsnittTitel;
        private TextBox txtKategori;
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
        private PictureBox pictureBox1;
        private ListBox lstAvsnitt;
        private Label lblRss;
        private Label lblMinaPoddar;
        private Panel panelAvsnittLista;
        private Label lblAvsnittSeparator;
        private Label lblAvsnittRubrik;
        private Panel panelAvsnittDetaljer;
        private PictureBox pbPoddBild;
        private Label label1;
    }
}
