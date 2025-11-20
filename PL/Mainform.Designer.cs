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
            SuspendLayout();
            // 
            // btnHamtaRss
            // 
            btnHamtaRss.Location = new Point(606, 25);
            btnHamtaRss.Name = "btnHamtaRss";
            btnHamtaRss.Size = new Size(111, 33);
            btnHamtaRss.TabIndex = 0;
            btnHamtaRss.Text = "HÃ¤mta RSS";
            btnHamtaRss.UseVisualStyleBackColor = true;
            btnHamtaRss.Click += btnHamtaRss_ClickAsync;
            // 
            // lstAvsnitt
            // 
            lstAvsnitt.FormattingEnabled = true;
            lstAvsnitt.Location = new Point(22, 56);
            lstAvsnitt.Name = "lstAvsnitt";
            lstAvsnitt.Size = new Size(350, 329);
            lstAvsnitt.TabIndex = 1;
            lstAvsnitt.SelectedIndexChanged += lstAvsnitt_SelectedIndexChanged;
            // 
            // txtDetaljer
            // 
            txtDetaljer.Location = new Point(369, 75);
            txtDetaljer.Multiline = true;
            txtDetaljer.Name = "txtDetaljer";
            txtDetaljer.ReadOnly = true;
            txtDetaljer.ScrollBars = ScrollBars.Both;
            txtDetaljer.Size = new Size(350, 329);
            txtDetaljer.TabIndex = 2;
            // 
            // txtRssUrl
            // 
            txtRssUrl.Location = new Point(11, 28);
            txtRssUrl.Name = "txtRssUrl";
            txtRssUrl.Size = new Size(588, 31);
            txtRssUrl.TabIndex = 3;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.Location = new Point(11, 425);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(111, 33);
            btnSparaPodd.TabIndex = 4;
            btnSparaPodd.Text = "Spara";
            btnSparaPodd.UseVisualStyleBackColor = true;
            btnSparaPodd.Click += btnSparaPodd_ClickAsync;
            // 
            // lstPoddar
            // 
            lstPoddar.FormattingEnabled = true;
            lstPoddar.Location = new Point(894, 75);
            lstPoddar.Name = "lstPoddar";
            lstPoddar.Size = new Size(350, 329);
            lstPoddar.TabIndex = 5;
            lstPoddar.SelectedIndexChanged += lstPoddar_SelectedIndexChangedAsync;
            // 
            // btnLaddaPoddar
            // 
            btnLaddaPoddar.Location = new Point(894, 25);
            btnLaddaPoddar.Name = "btnLaddaPoddar";
            btnLaddaPoddar.Size = new Size(350, 33);
            btnLaddaPoddar.TabIndex = 6;
            btnLaddaPoddar.Text = "Visa sparade poddar";
            btnLaddaPoddar.UseVisualStyleBackColor = true;
            btnLaddaPoddar.Click += btnLaddaPoddar_ClickAsync;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(361, 662);
            lblKategori.Margin = new Padding(4, 0, 4, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(78, 25);
            lblKategori.TabIndex = 7;
            lblKategori.Text = "Kategori";
            lblKategori.Click += label1_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(457, 657);
            cmbKategori.Margin = new Padding(4, 5, 4, 5);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(171, 33);
            cmbKategori.TabIndex = 8;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.Location = new Point(759, 662);
            btnAndraKategori.Margin = new Padding(4, 5, 4, 5);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(150, 38);
            btnAndraKategori.TabIndex = 9;
            btnAndraKategori.Text = "Ändra kategori";
            btnAndraKategori.UseVisualStyleBackColor = true;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(759, 710);
            btnTaBortKategori.Margin = new Padding(4, 5, 4, 5);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(150, 38);
            btnTaBortKategori.TabIndex = 10;
            btnTaBortKategori.Text = "Ta bort kategori";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Location = new Point(759, 758);
            btnLaggTillKategori.Margin = new Padding(4, 5, 4, 5);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(150, 38);
            btnLaggTillKategori.TabIndex = 11;
            btnLaggTillKategori.Text = "Lägg till kategori";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // txtNyKategori
            // 
            txtNyKategori.Location = new Point(963, 758);
            txtNyKategori.Margin = new Padding(4, 5, 4, 5);
            txtNyKategori.Name = "txtNyKategori";
            txtNyKategori.Size = new Size(141, 31);
            txtNyKategori.TabIndex = 12;
            txtNyKategori.Text = "Ny kategori";
            txtNyKategori.TextChanged += txtNyKategori_TextChanged;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1834, 1018);
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
    }
}
