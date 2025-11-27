namespace PL
{
    partial class EditKategoriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditKategoriForm));
            lblTitel = new Label();
            txtNamn = new TextBox();
            btnSpara = new Button();
            btnAvbryt = new Button();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.Location = new Point(12, 18);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(146, 20);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Nytt Kategorinamn";
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(12, 50);
            txtNamn.Name = "txtNamn";
            txtNamn.Size = new Size(280, 23);
            txtNamn.TabIndex = 1;
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(12, 100);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(100, 30);
            btnSpara.TabIndex = 2;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = true;
            btnSpara.Click += btnSpara_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(192, 100);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(100, 30);
            btnAvbryt.TabIndex = 3;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // EditKategoriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 161);
            Controls.Add(btnAvbryt);
            Controls.Add(btnSpara);
            Controls.Add(txtNamn);
            Controls.Add(lblTitel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditKategoriForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditKategoriForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private TextBox txtNamn;
        private Button btnSpara;
        private Button btnAvbryt;
    }
}