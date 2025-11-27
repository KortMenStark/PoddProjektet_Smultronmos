namespace PL
{
    partial class SavePoddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavePoddForm));
            txtNamn = new TextBox();
            cmbKategori = new ComboBox();
            btnSpara = new Button();
            btnAvbryt = new Button();
            lblNamn = new Label();
            lblKategori = new Label();
            btnNyKategori = new Button();
            SuspendLayout();
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(20, 45);
            txtNamn.Name = "txtNamn";
            txtNamn.Size = new Size(272, 23);
            txtNamn.TabIndex = 0;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(20, 106);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(170, 23);
            cmbKategori.TabIndex = 1;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(20, 169);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(85, 30);
            btnSpara.TabIndex = 2;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = true;
            btnSpara.Click += btnSpara_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(207, 169);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(85, 30);
            btnAvbryt.TabIndex = 3;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(20, 20);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(103, 15);
            lblNamn.TabIndex = 4;
            lblNamn.Text = "Namn på podden:";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(20, 80);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(99, 15);
            lblKategori.TabIndex = 5;
            lblKategori.Text = "Kategori (valfritt):";
            // 
            // btnNyKategori
            // 
            btnNyKategori.Location = new Point(207, 105);
            btnNyKategori.Name = "btnNyKategori";
            btnNyKategori.Size = new Size(85, 23);
            btnNyKategori.TabIndex = 6;
            btnNyKategori.Text = "Ny kategori";
            btnNyKategori.UseVisualStyleBackColor = true;
            btnNyKategori.Click += btnNyKategori_Click;
            // 
            // SavePoddForm
            // 
            AcceptButton = btnSpara;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAvbryt;
            ClientSize = new Size(304, 211);
            Controls.Add(btnNyKategori);
            Controls.Add(lblKategori);
            Controls.Add(lblNamn);
            Controls.Add(btnAvbryt);
            Controls.Add(btnSpara);
            Controls.Add(cmbKategori);
            Controls.Add(txtNamn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SavePoddForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Spara podd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamn;
        private ComboBox cmbKategori;
        private Button btnSpara;
        private Button btnAvbryt;
        private Label lblNamn;
        private Label lblKategori;
        private Button btnNyKategori;
    }
}