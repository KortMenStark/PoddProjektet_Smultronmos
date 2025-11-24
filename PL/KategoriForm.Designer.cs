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
            lstKategorier = new ListBox();
            btnRedigera = new Button();
            btnTaBort = new Button();
            SuspendLayout();
            // 
            // lstKategorier
            // 
            lstKategorier.FormattingEnabled = true;
            lstKategorier.Location = new Point(20, 20);
            lstKategorier.Name = "lstKategorier";
            lstKategorier.SelectionMode = SelectionMode.None;
            lstKategorier.Size = new Size(200, 244);
            lstKategorier.TabIndex = 0;
            // 
            // btnRedigera
            // 
            btnRedigera.Location = new Point(20, 290);
            btnRedigera.Name = "btnRedigera";
            btnRedigera.Size = new Size(120, 30);
            btnRedigera.TabIndex = 3;
            btnRedigera.Text = "Redigera namn";
            btnRedigera.UseVisualStyleBackColor = true;
            btnRedigera.Click += btnRedigera_Click;
            // 
            // btnTaBort
            // 
            btnTaBort.Location = new Point(160, 290);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(120, 30);
            btnTaBort.TabIndex = 4;
            btnTaBort.Text = "Ta bort kategori";
            btnTaBort.UseVisualStyleBackColor = true;
            btnTaBort.Click += btnTaBort_Click;
            // 
            // KategoriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 341);
            Controls.Add(btnTaBort);
            Controls.Add(btnRedigera);
            Controls.Add(lstKategorier);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "KategoriForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "KategoriForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstKategorier;
        private Button btnRedigera;
        private Button btnTaBort;
    }
}