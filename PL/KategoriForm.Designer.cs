namespace PL
{
    partial class KategoriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriForm));
            lstKategorier = new ListBox();
            btnRedigera = new Button();
            btnTaBort = new Button();
            btnNyKategori = new Button();
            SuspendLayout();
            // 
            // lstKategorier
            // 
            lstKategorier.FormattingEnabled = true;
            lstKategorier.Location = new Point(20, 20);
            lstKategorier.Name = "lstKategorier";
            lstKategorier.Size = new Size(150, 244);
            lstKategorier.TabIndex = 0;
            // 
            // btnRedigera
            // 
            btnRedigera.Location = new Point(176, 198);
            btnRedigera.Name = "btnRedigera";
            btnRedigera.Size = new Size(104, 30);
            btnRedigera.TabIndex = 3;
            btnRedigera.Text = "Redigera namn";
            btnRedigera.UseVisualStyleBackColor = true;
            btnRedigera.Click += btnRedigera_Click;
            // 
            // btnTaBort
            // 
            btnTaBort.Location = new Point(176, 234);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(104, 30);
            btnTaBort.TabIndex = 4;
            btnTaBort.Text = "Ta bort kategori";
            btnTaBort.UseVisualStyleBackColor = true;
            btnTaBort.Click += btnTaBort_Click;
            // 
            // btnNyKategori
            // 
            btnNyKategori.Location = new Point(176, 162);
            btnNyKategori.Name = "btnNyKategori";
            btnNyKategori.Size = new Size(104, 30);
            btnNyKategori.TabIndex = 5;
            btnNyKategori.Text = "Lägg till";
            btnNyKategori.UseVisualStyleBackColor = true;
            btnNyKategori.Click += btnNyKategori_Click;
            // 
            // KategoriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 281);
            Controls.Add(btnNyKategori);
            Controls.Add(btnTaBort);
            Controls.Add(btnRedigera);
            Controls.Add(lstKategorier);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KategoriForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "KategoriForm";
            Load += KategoriForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstKategorier;
        private Button btnRedigera;
        private Button btnTaBort;
        private Button btnNyKategori;
    }
}