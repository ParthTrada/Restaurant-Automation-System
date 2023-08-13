namespace Restaurant_Otomasyonu
{
    partial class frmGiris
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
            cbKullanici = new ComboBox();
            txtSifre = new TextBox();
            button1 = new Button();
            btnCikis = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbKullanici
            // 
            cbKullanici.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKullanici.FormattingEnabled = true;
            cbKullanici.Location = new Point(825, 497);
            cbKullanici.Margin = new Padding(4);
            cbKullanici.Name = "cbKullanici";
            cbKullanici.Size = new Size(360, 33);
            cbKullanici.TabIndex = 0;
            cbKullanici.SelectedIndexChanged += cbKullanici_SelectedIndexChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(825, 553);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(360, 30);
            txtSifre.TabIndex = 1;
            txtSifre.TextAlign = HorizontalAlignment.Center;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.giriss;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(825, 591);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(223, 71);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Transparent;
            btnCikis.BackgroundImage = Properties.Resources.cikiss;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.FlatStyle = FlatStyle.Popup;
            btnCikis.ForeColor = Color.Transparent;
            btnCikis.Location = new Point(1079, 591);
            btnCikis.Margin = new Padding(4);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(106, 71);
            btnCikis.TabIndex = 3;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(825, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 314);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(633, 497);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(633, 550);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 6;
            label2.Text = "Şifre";
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1883, 755);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCikis);
            Controls.Add(button1);
            Controls.Add(txtSifre);
            Controls.Add(cbKullanici);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += frmGiris_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKullanici;
        private TextBox txtSifre;
        private Button button1;
        private Button btnCikis;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}