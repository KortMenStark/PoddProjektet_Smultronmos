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
            SuspendLayout();
            // 
            // btnHamtaRss
            // 
            btnHamtaRss.Location = new Point(606, 25);
            btnHamtaRss.Name = "btnHamtaRss";
            btnHamtaRss.Size = new Size(112, 34);
            btnHamtaRss.TabIndex = 0;
            btnHamtaRss.Text = "HÃ¤mta RSS";
            btnHamtaRss.UseVisualStyleBackColor = true;
            btnHamtaRss.Click += btnHamtaRss_ClickAsync;
            // 
            // lstAvsnitt
            // 
            lstAvsnitt.FormattingEnabled = true;
            lstAvsnitt.Location = new Point(12, 75);
            lstAvsnitt.Name = "lstAvsnitt";
            lstAvsnitt.Size = new Size(350, 329);
            lstAvsnitt.TabIndex = 1;
            lstAvsnitt.SelectedIndexChanged += lstAvsnitt_SelectedIndexChanged;
            // 
            // txtDetaljer
            // 
            txtDetaljer.Location = new Point(368, 75);
            txtDetaljer.Multiline = true;
            txtDetaljer.Name = "txtDetaljer";
            txtDetaljer.ReadOnly = true;
            txtDetaljer.ScrollBars = ScrollBars.Both;
            txtDetaljer.Size = new Size(350, 329);
            txtDetaljer.TabIndex = 2;
            // 
            // txtRssUrl
            // 
            txtRssUrl.Location = new Point(12, 28);
            txtRssUrl.Name = "txtRssUrl";
            txtRssUrl.Size = new Size(588, 31);
            txtRssUrl.TabIndex = 3;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.Location = new Point(12, 425);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(112, 34);
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
            btnLaddaPoddar.Size = new Size(350, 34);
            btnLaddaPoddar.TabIndex = 6;
            btnLaddaPoddar.Text = "Visa sparade poddar";
            btnLaddaPoddar.UseVisualStyleBackColor = true;
            btnLaddaPoddar.Click += btnLaddaPoddar_ClickAsync;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 729);
            Controls.Add(btnLaddaPoddar);
            Controls.Add(lstPoddar);
            Controls.Add(btnSparaPodd);
            Controls.Add(txtRssUrl);
            Controls.Add(txtDetaljer);
            Controls.Add(lstAvsnitt);
            Controls.Add(btnHamtaRss);
            Name = "Mainform";
            Text = "Form1";
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
    }
}
