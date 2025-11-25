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
            labelKategori = new Label();
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
            panelLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnHamtaRss
            // 
            btnHamtaRss.BackColor = Color.FromArgb(55, 70, 95);
            btnHamtaRss.FlatAppearance.BorderSize = 0;
            btnHamtaRss.FlatStyle = FlatStyle.Flat;
            btnHamtaRss.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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
            txtRssUrl.BorderStyle = BorderStyle.None;
            txtRssUrl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRssUrl.ForeColor = Color.Black;
            txtRssUrl.Location = new Point(3, 683);
            txtRssUrl.Margin = new Padding(2);
            txtRssUrl.Name = "txtRssUrl";
            txtRssUrl.Size = new Size(173, 22);
            txtRssUrl.TabIndex = 3;
            txtRssUrl.TextChanged += txtRssUrl_TextChanged;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.FlatAppearance.BorderSize = 0;
            btnSparaPodd.FlatStyle = FlatStyle.Flat;
            btnSparaPodd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSparaPodd.Image = Properties.Resources.diskette_save_24;
            btnSparaPodd.Location = new Point(0, 280);
            btnSparaPodd.Margin = new Padding(2);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(190, 60);
            btnSparaPodd.TabIndex = 4;
            btnSparaPodd.Text = "Spara";
            btnSparaPodd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSparaPodd.UseVisualStyleBackColor = true;
            btnSparaPodd.Click += btnSparaPodd_Click;
            // 
            // lstPoddar
            // 
            lstPoddar.BackColor = Color.White;
            lstPoddar.BorderStyle = BorderStyle.None;
            lstPoddar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPoddar.ForeColor = Color.Black;
            lstPoddar.FormattingEnabled = true;
            lstPoddar.Location = new Point(240, 140);
            lstPoddar.Margin = new Padding(2);
            lstPoddar.Name = "lstPoddar";
            lstPoddar.Size = new Size(240, 630);
            lstPoddar.TabIndex = 5;
            lstPoddar.SelectedIndexChanged += lstPoddar_SelectedIndexChangedAsync;
            // 
            // btnLaddaPoddar
            // 
            btnLaddaPoddar.FlatAppearance.BorderSize = 0;
            btnLaddaPoddar.FlatStyle = FlatStyle.Flat;
            btnLaddaPoddar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLaddaPoddar.ForeColor = SystemColors.ControlText;
            btnLaddaPoddar.Image = Properties.Resources.icons8_load_24;
            btnLaddaPoddar.Location = new Point(3, 140);
            btnLaddaPoddar.Margin = new Padding(2);
            btnLaddaPoddar.Name = "btnLaddaPoddar";
            btnLaddaPoddar.Size = new Size(190, 60);
            btnLaddaPoddar.TabIndex = 6;
            btnLaddaPoddar.Text = "Mina poddar";
            btnLaddaPoddar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLaddaPoddar.UseVisualStyleBackColor = true;
            btnLaddaPoddar.Click += btnLaddaPoddar_ClickAsync;
            // 
            // txtTitel
            // 
            txtTitel.BackColor = Color.White;
            txtTitel.BorderStyle = BorderStyle.None;
            txtTitel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitel.ForeColor = Color.Black;
            txtTitel.Location = new Point(540, 95);
            txtTitel.Name = "txtTitel";
            txtTitel.ReadOnly = true;
            txtTitel.Size = new Size(450, 26);
            txtTitel.TabIndex = 13;
            // 
            // txtBeskrivning
            // 
            txtBeskrivning.BackColor = Color.White;
            txtBeskrivning.BorderStyle = BorderStyle.None;
            txtBeskrivning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBeskrivning.ForeColor = Color.Black;
            txtBeskrivning.Location = new Point(1047, 394);
            txtBeskrivning.Multiline = true;
            txtBeskrivning.Name = "txtBeskrivning";
            txtBeskrivning.ReadOnly = true;
            txtBeskrivning.ScrollBars = ScrollBars.Vertical;
            txtBeskrivning.Size = new Size(344, 376);
            txtBeskrivning.TabIndex = 14;
            // 
            // cbmFilterKategori
            // 
            cbmFilterKategori.FormattingEnabled = true;
            cbmFilterKategori.Location = new Point(3, 578);
            cbmFilterKategori.Name = "cbmFilterKategori";
            cbmFilterKategori.Size = new Size(173, 23);
            cbmFilterKategori.TabIndex = 16;
            cbmFilterKategori.SelectedIndexChanged += cbmFilterKategori_SelectedIndexChanged;
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelKategori.ForeColor = Color.Black;
            labelKategori.Location = new Point(3, 560);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(84, 15);
            labelKategori.TabIndex = 17;
            labelKategori.Text = "Mina kategori";
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitel.ForeColor = Color.Black;
            lblTitel.Location = new Point(540, 77);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(61, 15);
            lblTitel.TabIndex = 18;
            lblTitel.Text = "Podd titel";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBeskrivning.ForeColor = Color.Black;
            lblBeskrivning.Location = new Point(1049, 369);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(73, 15);
            lblBeskrivning.TabIndex = 19;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // btnAvprenumerera
            // 
            btnAvprenumerera.FlatAppearance.BorderSize = 0;
            btnAvprenumerera.FlatStyle = FlatStyle.Flat;
            btnAvprenumerera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAvprenumerera.ForeColor = SystemColors.ControlText;
            btnAvprenumerera.Image = Properties.Resources.Unsub_24;
            btnAvprenumerera.Location = new Point(0, 345);
            btnAvprenumerera.Name = "btnAvprenumerera";
            btnAvprenumerera.Size = new Size(190, 60);
            btnAvprenumerera.TabIndex = 21;
            btnAvprenumerera.Text = "Avprenumerera";
            btnAvprenumerera.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAvprenumerera.UseVisualStyleBackColor = true;
            btnAvprenumerera.Click += btnAvprenumerera_ClickAsync;
            // 
            // txtAvsnittTitel
            // 
            txtAvsnittTitel.BackColor = Color.White;
            txtAvsnittTitel.BorderStyle = BorderStyle.None;
            txtAvsnittTitel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAvsnittTitel.ForeColor = Color.Black;
            txtAvsnittTitel.Location = new Point(1049, 159);
            txtAvsnittTitel.Margin = new Padding(3, 2, 3, 2);
            txtAvsnittTitel.Name = "txtAvsnittTitel";
            txtAvsnittTitel.ReadOnly = true;
            txtAvsnittTitel.Size = new Size(342, 22);
            txtAvsnittTitel.TabIndex = 22;
            // 
            // lblAvsnittTitel
            // 
            lblAvsnittTitel.AutoSize = true;
            lblAvsnittTitel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAvsnittTitel.ForeColor = Color.Black;
            lblAvsnittTitel.Location = new Point(1047, 125);
            lblAvsnittTitel.Name = "lblAvsnittTitel";
            lblAvsnittTitel.Size = new Size(75, 15);
            lblAvsnittTitel.TabIndex = 23;
            lblAvsnittTitel.Text = "Avsnittstitel";
            // 
            // txtKategori
            // 
            txtKategori.BackColor = Color.White;
            txtKategori.BorderStyle = BorderStyle.None;
            txtKategori.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKategori.ForeColor = Color.Black;
            txtKategori.Location = new Point(1049, 234);
            txtKategori.Margin = new Padding(3, 2, 3, 2);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(342, 22);
            txtKategori.TabIndex = 24;
            // 
            // lblAktuellkategori
            // 
            lblAktuellkategori.AutoSize = true;
            lblAktuellkategori.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAktuellkategori.ForeColor = Color.Black;
            lblAktuellkategori.Location = new Point(1049, 205);
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
            cmbKategori.Location = new Point(3, 516);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(173, 23);
            cmbKategori.TabIndex = 26;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.FlatAppearance.BorderSize = 0;
            btnAndraKategori.FlatStyle = FlatStyle.Flat;
            btnAndraKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAndraKategori.ForeColor = SystemColors.ControlText;
            btnAndraKategori.Image = Properties.Resources.edit_24;
            btnAndraKategori.Location = new Point(0, 420);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(190, 60);
            btnAndraKategori.TabIndex = 27;
            btnAndraKategori.Text = "Ändra Kategori";
            btnAndraKategori.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAndraKategori.UseVisualStyleBackColor = true;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // lblNyKategori
            // 
            lblNyKategori.AutoSize = true;
            lblNyKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNyKategori.ForeColor = SystemColors.ControlText;
            lblNyKategori.Location = new Point(3, 496);
            lblNyKategori.Name = "lblNyKategori";
            lblNyKategori.Size = new Size(84, 17);
            lblNyKategori.TabIndex = 28;
            lblNyKategori.Text = "Ny kategori:";
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
            panelLeft.Controls.Add(labelKategori);
            panelLeft.Controls.Add(panel1);
            panelLeft.Controls.Add(txtRssUrl);
            panelLeft.Controls.Add(btnHamtaRss);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 811);
            panelLeft.TabIndex = 29;
            // 
            // lblRss
            // 
            lblRss.AutoSize = true;
            lblRss.Location = new Point(0, 657);
            lblRss.Name = "lblRss";
            lblRss.Size = new Size(84, 15);
            lblRss.TabIndex = 29;
            lblRss.Text = "Klistra in länk:";
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.FlatAppearance.BorderSize = 0;
            btnHanteraKategorier.FlatStyle = FlatStyle.Flat;
            btnHanteraKategorier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHanteraKategorier.ForeColor = SystemColors.ControlText;
            btnHanteraKategorier.Image = Properties.Resources.icons8_folder_24;
            btnHanteraKategorier.Location = new Point(0, 215);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(190, 60);
            btnHanteraKategorier.TabIndex = 22;
            btnHanteraKategorier.Text = "Hantera kategorier";
            btnHanteraKategorier.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHanteraKategorier.UseVisualStyleBackColor = true;
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
            lblPodcast.Size = new Size(64, 17);
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
            txtPubliceringsdatum.BackColor = Color.White;
            txtPubliceringsdatum.BorderStyle = BorderStyle.None;
            txtPubliceringsdatum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPubliceringsdatum.ForeColor = Color.Black;
            txtPubliceringsdatum.Location = new Point(1049, 299);
            txtPubliceringsdatum.Name = "txtPubliceringsdatum";
            txtPubliceringsdatum.ReadOnly = true;
            txtPubliceringsdatum.Size = new Size(342, 22);
            txtPubliceringsdatum.TabIndex = 15;
            // 
            // lblUtgivningsdatum
            // 
            lblUtgivningsdatum.AutoSize = true;
            lblUtgivningsdatum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUtgivningsdatum.ForeColor = Color.Black;
            lblUtgivningsdatum.Location = new Point(1049, 280);
            lblUtgivningsdatum.Name = "lblUtgivningsdatum";
            lblUtgivningsdatum.Size = new Size(103, 15);
            lblUtgivningsdatum.TabIndex = 20;
            lblUtgivningsdatum.Text = "Utgivningsdatum";
            // 
            // lstAvsnitt
            // 
            lstAvsnitt.BackColor = Color.White;
            lstAvsnitt.BorderStyle = BorderStyle.None;
            lstAvsnitt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstAvsnitt.ForeColor = Color.Black;
            lstAvsnitt.FormattingEnabled = true;
            lstAvsnitt.Location = new Point(540, 140);
            lstAvsnitt.Margin = new Padding(2);
            lstAvsnitt.Name = "lstAvsnitt";
            lstAvsnitt.Size = new Size(450, 630);
            lstAvsnitt.TabIndex = 1;
            lstAvsnitt.SelectedIndexChanged += lstAvsnitt_SelectedIndexChanged;
            // 
            // lblMinaPoddar
            // 
            lblMinaPoddar.AutoSize = true;
            lblMinaPoddar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinaPoddar.Location = new Point(240, 96);
            lblMinaPoddar.Name = "lblMinaPoddar";
            lblMinaPoddar.Size = new Size(127, 25);
            lblMinaPoddar.TabIndex = 30;
            lblMinaPoddar.Text = "Mina Poddar";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1434, 811);
            Controls.Add(lblMinaPoddar);
            Controls.Add(lstAvsnitt);
            Controls.Add(lblAktuellkategori);
            Controls.Add(txtKategori);
            Controls.Add(lblAvsnittTitel);
            Controls.Add(txtAvsnittTitel);
            Controls.Add(lblUtgivningsdatum);
            Controls.Add(lblBeskrivning);
            Controls.Add(lblTitel);
            Controls.Add(txtPubliceringsdatum);
            Controls.Add(txtBeskrivning);
            Controls.Add(txtTitel);
            Controls.Add(lstPoddar);
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
        private Label labelKategori;
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
    }
}
