namespace PL
{
    partial class EditPodNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPodNameForm));
            btnSpara = new Button();
            btnAvbryt = new Button();
            txtNyttNamn = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(12, 100);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(100, 30);
            btnSpara.TabIndex = 0;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = true;
            btnSpara.Click += btnSpara_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(192, 100);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(100, 30);
            btnAvbryt.TabIndex = 1;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // txtNyttNamn
            // 
            txtNyttNamn.Location = new Point(12, 50);
            txtNyttNamn.Name = "txtNyttNamn";
            txtNyttNamn.Size = new Size(280, 23);
            txtNyttNamn.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 3;
            label1.Text = "Ange nytt namn för podden:";
            // 
            // EditPodNameForm
            // 
            AcceptButton = btnSpara;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAvbryt;
            ClientSize = new Size(304, 161);
            Controls.Add(label1);
            Controls.Add(txtNyttNamn);
            Controls.Add(btnAvbryt);
            Controls.Add(btnSpara);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditPodNameForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bytt namn på podd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSpara;
        private Button btnAvbryt;
        private TextBox txtNyttNamn;
        private Label label1;
    }
}