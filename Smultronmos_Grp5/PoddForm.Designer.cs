namespace PL_Presentationslager
{
    partial class PoddForm
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
            dgvPoddar = new DataGridView();
            lblSok = new Label();
            txtSokTitel = new TextBox();
            cmbFilterKategori = new ComboBox();
            btnSok = new Button();
            grpDetaljer = new GroupBox();
            picOmslag = new PictureBox();
            txtBeskrivning = new TextBox();
            lblBeskrivning = new Label();
            txtRss = new TextBox();
            lblRss = new Label();
            txtAntalAvsnitt = new TextBox();
            lblAntalAvsnitt = new Label();
            cmbKategori = new ComboBox();
            lblKategori = new Label();
            txtHost = new TextBox();
            lblHost = new Label();
            txtTitel = new TextBox();
            lblTitel = new Label();
            btnLaggTill = new Button();
            btnRedigera = new Button();
            btnTaBort = new Button();
            btnSpara = new Button();
            btnAvbryt = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPoddar).BeginInit();
            grpDetaljer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOmslag).BeginInit();
            SuspendLayout();
            // 
            // dgvPoddar
            // 
            dgvPoddar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvPoddar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoddar.Location = new Point(10, 60);
            dgvPoddar.MultiSelect = false;
            dgvPoddar.Name = "dgvPoddar";
            dgvPoddar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoddar.Size = new Size(550, 450);
            dgvPoddar.TabIndex = 0;
            // 
            // lblSok
            // 
            lblSok.AutoSize = true;
            lblSok.Location = new Point(10, 20);
            lblSok.Name = "lblSok";
            lblSok.Size = new Size(60, 15);
            lblSok.TabIndex = 1;
            lblSok.Text = "Sök (titel):";
            // 
            // txtSokTitel
            // 
            txtSokTitel.Location = new Point(75, 18);
            txtSokTitel.Name = "txtSokTitel";
            txtSokTitel.Size = new Size(200, 23);
            txtSokTitel.TabIndex = 2;
            // 
            // cmbFilterKategori
            // 
            cmbFilterKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterKategori.FormattingEnabled = true;
            cmbFilterKategori.Location = new Point(310, 18);
            cmbFilterKategori.Name = "cmbFilterKategori";
            cmbFilterKategori.Size = new Size(150, 23);
            cmbFilterKategori.TabIndex = 3;
            // 
            // btnSok
            // 
            btnSok.Location = new Point(470, 16);
            btnSok.Name = "btnSok";
            btnSok.Size = new Size(80, 23);
            btnSok.TabIndex = 4;
            btnSok.Text = "Sök";
            btnSok.UseVisualStyleBackColor = true;
            // 
            // grpDetaljer
            // 
            grpDetaljer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpDetaljer.Controls.Add(picOmslag);
            grpDetaljer.Controls.Add(txtBeskrivning);
            grpDetaljer.Controls.Add(lblBeskrivning);
            grpDetaljer.Controls.Add(txtRss);
            grpDetaljer.Controls.Add(lblRss);
            grpDetaljer.Controls.Add(txtAntalAvsnitt);
            grpDetaljer.Controls.Add(lblAntalAvsnitt);
            grpDetaljer.Controls.Add(cmbKategori);
            grpDetaljer.Controls.Add(lblKategori);
            grpDetaljer.Controls.Add(txtHost);
            grpDetaljer.Controls.Add(lblHost);
            grpDetaljer.Controls.Add(txtTitel);
            grpDetaljer.Controls.Add(lblTitel);
            grpDetaljer.Location = new Point(580, 60);
            grpDetaljer.Name = "grpDetaljer";
            grpDetaljer.Size = new Size(390, 450);
            grpDetaljer.TabIndex = 5;
            grpDetaljer.TabStop = false;
            grpDetaljer.Text = "Podd-detaljer";
            // 
            // picOmslag
            // 
            picOmslag.Location = new Point(120, 308);
            picOmslag.Name = "picOmslag";
            picOmslag.Size = new Size(120, 120);
            picOmslag.SizeMode = PictureBoxSizeMode.StretchImage;
            picOmslag.TabIndex = 6;
            picOmslag.TabStop = false;
            // 
            // txtBeskrivning
            // 
            txtBeskrivning.Location = new Point(120, 208);
            txtBeskrivning.Multiline = true;
            txtBeskrivning.Name = "txtBeskrivning";
            txtBeskrivning.ScrollBars = ScrollBars.Vertical;
            txtBeskrivning.Size = new Size(240, 80);
            txtBeskrivning.TabIndex = 11;
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(10, 210);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(71, 15);
            lblBeskrivning.TabIndex = 10;
            lblBeskrivning.Text = "Beskrivning:";
            // 
            // txtRss
            // 
            txtRss.Location = new Point(120, 178);
            txtRss.Name = "txtRss";
            txtRss.Size = new Size(240, 23);
            txtRss.TabIndex = 9;
            // 
            // lblRss
            // 
            lblRss.AutoSize = true;
            lblRss.Location = new Point(10, 180);
            lblRss.Name = "lblRss";
            lblRss.Size = new Size(55, 15);
            lblRss.TabIndex = 8;
            lblRss.Text = "RSS/URL:";
            // 
            // txtAntalAvsnitt
            // 
            txtAntalAvsnitt.Location = new Point(120, 118);
            txtAntalAvsnitt.Name = "txtAntalAvsnitt";
            txtAntalAvsnitt.Size = new Size(80, 23);
            txtAntalAvsnitt.TabIndex = 7;
            // 
            // lblAntalAvsnitt
            // 
            lblAntalAvsnitt.AutoSize = true;
            lblAntalAvsnitt.Location = new Point(10, 120);
            lblAntalAvsnitt.Name = "lblAntalAvsnitt";
            lblAntalAvsnitt.Size = new Size(76, 15);
            lblAntalAvsnitt.TabIndex = 6;
            lblAntalAvsnitt.Text = "Antal avsnitt:";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(120, 88);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(240, 23);
            cmbKategori.TabIndex = 5;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(10, 90);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(54, 15);
            lblKategori.TabIndex = 4;
            lblKategori.Text = "Kategori:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(120, 58);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(240, 23);
            txtHost.TabIndex = 3;
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(10, 60);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(35, 15);
            lblHost.TabIndex = 2;
            lblHost.Text = "Host:";
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(120, 28);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(240, 23);
            txtTitel.TabIndex = 1;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(10, 30);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(32, 15);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Titel:";
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(10, 530);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(75, 23);
            btnLaggTill.TabIndex = 6;
            btnLaggTill.Text = "Lägg till";
            btnLaggTill.UseVisualStyleBackColor = true;
            // 
            // btnRedigera
            // 
            btnRedigera.Location = new Point(110, 530);
            btnRedigera.Name = "btnRedigera";
            btnRedigera.Size = new Size(75, 23);
            btnRedigera.TabIndex = 7;
            btnRedigera.Text = "Redigera";
            btnRedigera.UseVisualStyleBackColor = true;
            // 
            // btnTaBort
            // 
            btnTaBort.Location = new Point(210, 530);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(75, 23);
            btnTaBort.TabIndex = 8;
            btnTaBort.Text = "Ta bort";
            btnTaBort.UseVisualStyleBackColor = true;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(310, 530);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(75, 23);
            btnSpara.TabIndex = 9;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = true;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(410, 530);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(75, 23);
            btnAvbryt.TabIndex = 10;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            // 
            // PoddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(btnAvbryt);
            Controls.Add(btnSpara);
            Controls.Add(btnTaBort);
            Controls.Add(btnRedigera);
            Controls.Add(btnLaggTill);
            Controls.Add(grpDetaljer);
            Controls.Add(btnSok);
            Controls.Add(cmbFilterKategori);
            Controls.Add(txtSokTitel);
            Controls.Add(lblSok);
            Controls.Add(dgvPoddar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PoddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poddhanterare";
            ((System.ComponentModel.ISupportInitialize)dgvPoddar).EndInit();
            grpDetaljer.ResumeLayout(false);
            grpDetaljer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOmslag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPoddar;
        private Label lblSok;
        private TextBox txtSokTitel;
        private ComboBox cmbFilterKategori;
        private Button btnSok;
        private GroupBox grpDetaljer;
        private TextBox txtTitel;
        private Label lblTitel;
        private Label lblHost;
        private ComboBox cmbKategori;
        private Label lblKategori;
        private TextBox txtHost;
        private Label lblAntalAvsnitt;
        private TextBox txtBeskrivning;
        private Label lblBeskrivning;
        private TextBox txtRss;
        private Label lblRss;
        private TextBox txtAntalAvsnitt;
        private PictureBox picOmslag;
        private Button btnLaggTill;
        private Button btnRedigera;
        private Button btnTaBort;
        private Button btnSpara;
        private Button btnAvbryt;
    }
}
