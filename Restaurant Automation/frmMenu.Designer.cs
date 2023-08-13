namespace Restaurant_Otomasyonu
{
    partial class frmMenu
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
            btnMasaSiparis = new Button();
            btnMutfak = new Button();
            btnAyarlar = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // btnMasaSiparis
            // 
            btnMasaSiparis.BackgroundImage = Properties.Resources.masa;
            btnMasaSiparis.BackgroundImageLayout = ImageLayout.Stretch;
            btnMasaSiparis.FlatStyle = FlatStyle.Popup;
            btnMasaSiparis.Location = new Point(456, 87);
            btnMasaSiparis.Name = "btnMasaSiparis";
            btnMasaSiparis.Size = new Size(624, 371);
            btnMasaSiparis.TabIndex = 0;
            btnMasaSiparis.UseVisualStyleBackColor = true;
            btnMasaSiparis.Click += btnMasaSiparis_Click;
            // 
            // btnMutfak
            // 
            btnMutfak.BackgroundImage = Properties.Resources.mutfak;
            btnMutfak.BackgroundImageLayout = ImageLayout.Stretch;
            btnMutfak.FlatStyle = FlatStyle.Popup;
            btnMutfak.Location = new Point(885, 465);
            btnMutfak.Name = "btnMutfak";
            btnMutfak.Size = new Size(558, 371);
            btnMutfak.TabIndex = 5;
            btnMutfak.UseVisualStyleBackColor = true;
            btnMutfak.Click += btnMutfak_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackgroundImage = Properties.Resources.ayarlar;
            btnAyarlar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAyarlar.FlatStyle = FlatStyle.Popup;
            btnAyarlar.Location = new Point(1086, 87);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(357, 371);
            btnAyarlar.TabIndex = 7;
            btnAyarlar.UseVisualStyleBackColor = true;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Transparent;
            btnCikis.BackgroundImage = Properties.Resources.cikiss;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.FlatStyle = FlatStyle.Popup;
            btnCikis.Location = new Point(456, 464);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(423, 373);
            btnCikis.TabIndex = 9;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1934, 963);
            Controls.Add(btnCikis);
            Controls.Add(btnAyarlar);
            Controls.Add(btnMutfak);
            Controls.Add(btnMasaSiparis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenu";
            Text = "frmMenu";
            WindowState = FormWindowState.Maximized;
            Load += frmMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMasaSiparis;
        private Button btnMutfak;
        private Button btnAyarlar;
        private Button btnCikis;
    }
}