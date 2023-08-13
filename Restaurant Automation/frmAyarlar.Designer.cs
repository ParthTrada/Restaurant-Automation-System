namespace Restaurant_Otomasyonu
{
    partial class frmAyarlar
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            cbPersonel = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtYeniSifretekrar = new TextBox();
            txtPersonelId = new TextBox();
            txtYeniSifre = new TextBox();
            groupBox2 = new GroupBox();
            btnBilgiDegistir = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            btnYeni = new Button();
            txtGorevId2 = new TextBox();
            txtPersonelD = new TextBox();
            cbGorevi = new ComboBox();
            txtSifreTekrar = new TextBox();
            txtSifre = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblBilgi = new Label();
            btnCikis = new Button();
            btnGeri = new Button();
            lvPersoneller = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cbPersonel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtYeniSifretekrar);
            groupBox1.Controls.Add(txtPersonelId);
            groupBox1.Controls.Add(txtYeniSifre);
            groupBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(179, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 518);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.degistir2;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(211, 292);
            button1.Name = "button1";
            button1.Size = new Size(281, 165);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbPersonel
            // 
            cbPersonel.FormattingEnabled = true;
            cbPersonel.Location = new Point(239, 118);
            cbPersonel.Name = "cbPersonel";
            cbPersonel.Size = new Size(252, 44);
            cbPersonel.TabIndex = 3;
            cbPersonel.SelectedIndexChanged += cbPersonel_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 222);
            label2.Name = "label2";
            label2.Size = new Size(235, 42);
            label2.TabIndex = 2;
            label2.Text = "T Yeni Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 168);
            label1.Name = "label1";
            label1.Size = new Size(211, 42);
            label1.TabIndex = 1;
            label1.Text = "Yeni Şifre :";
            // 
            // txtYeniSifretekrar
            // 
            txtYeniSifretekrar.Location = new Point(239, 225);
            txtYeniSifretekrar.Multiline = true;
            txtYeniSifretekrar.Name = "txtYeniSifretekrar";
            txtYeniSifretekrar.Size = new Size(252, 51);
            txtYeniSifretekrar.TabIndex = 0;
            // 
            // txtPersonelId
            // 
            txtPersonelId.Location = new Point(497, 118);
            txtPersonelId.Multiline = true;
            txtPersonelId.Name = "txtPersonelId";
            txtPersonelId.Size = new Size(18, 44);
            txtPersonelId.TabIndex = 0;
            txtPersonelId.Visible = false;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(239, 168);
            txtYeniSifre.Multiline = true;
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(252, 51);
            txtYeniSifre.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnBilgiDegistir);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnEkle);
            groupBox2.Controls.Add(btnYeni);
            groupBox2.Controls.Add(txtGorevId2);
            groupBox2.Controls.Add(txtPersonelD);
            groupBox2.Controls.Add(cbGorevi);
            groupBox2.Controls.Add(txtSifreTekrar);
            groupBox2.Controls.Add(txtSifre);
            groupBox2.Controls.Add(txtSoyad);
            groupBox2.Controls.Add(txtAd);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(745, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(565, 751);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnBilgiDegistir
            // 
            btnBilgiDegistir.BackgroundImage = Properties.Resources.degistir2;
            btnBilgiDegistir.BackgroundImageLayout = ImageLayout.Stretch;
            btnBilgiDegistir.Location = new Point(278, 559);
            btnBilgiDegistir.Name = "btnBilgiDegistir";
            btnBilgiDegistir.Size = new Size(253, 165);
            btnBilgiDegistir.TabIndex = 4;
            btnBilgiDegistir.UseVisualStyleBackColor = true;
            btnBilgiDegistir.Click += btnBilgiDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = Properties.Resources.sil1;
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.Location = new Point(19, 559);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(253, 165);
            btnSil.TabIndex = 4;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackgroundImage = Properties.Resources.kaydet;
            btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnEkle.Location = new Point(278, 388);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(253, 165);
            btnEkle.TabIndex = 4;
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnYeni
            // 
            btnYeni.BackgroundImage = Properties.Resources.yeni;
            btnYeni.BackgroundImageLayout = ImageLayout.Stretch;
            btnYeni.Location = new Point(19, 388);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(253, 165);
            btnYeni.TabIndex = 4;
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // txtGorevId2
            // 
            txtGorevId2.Location = new Point(519, 318);
            txtGorevId2.Multiline = true;
            txtGorevId2.Name = "txtGorevId2";
            txtGorevId2.Size = new Size(24, 46);
            txtGorevId2.TabIndex = 8;
            txtGorevId2.Visible = false;
            // 
            // txtPersonelD
            // 
            txtPersonelD.Location = new Point(519, 118);
            txtPersonelD.Multiline = true;
            txtPersonelD.Name = "txtPersonelD";
            txtPersonelD.Size = new Size(16, 46);
            txtPersonelD.TabIndex = 7;
            txtPersonelD.Visible = false;
            // 
            // cbGorevi
            // 
            cbGorevi.FormattingEnabled = true;
            cbGorevi.Location = new Point(261, 320);
            cbGorevi.Name = "cbGorevi";
            cbGorevi.Size = new Size(252, 44);
            cbGorevi.TabIndex = 6;
            cbGorevi.SelectedIndexChanged += cbGorevi_SelectedIndexChanged;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(261, 268);
            txtSifreTekrar.Multiline = true;
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(252, 46);
            txtSifreTekrar.TabIndex = 5;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(261, 216);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(252, 46);
            txtSifre.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(261, 164);
            txtSoyad.Multiline = true;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(252, 46);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(261, 116);
            txtAd.Multiline = true;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(252, 46);
            txtAd.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 331);
            label7.Name = "label7";
            label7.Size = new Size(134, 42);
            label7.TabIndex = 4;
            label7.Text = "Görevi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 276);
            label6.Name = "label6";
            label6.Size = new Size(224, 42);
            label6.TabIndex = 4;
            label6.Text = "Şifre Tekrar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 222);
            label5.Name = "label5";
            label5.Size = new Size(99, 42);
            label5.TabIndex = 4;
            label5.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 168);
            label4.Name = "label4";
            label4.Size = new Size(139, 42);
            label4.TabIndex = 3;
            label4.Text = "Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 120);
            label3.Name = "label3";
            label3.Size = new Size(75, 42);
            label3.TabIndex = 2;
            label3.Text = "Adı";
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.BackColor = Color.Transparent;
            lblBilgi.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblBilgi.ForeColor = Color.Red;
            lblBilgi.Location = new Point(179, 9);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(232, 42);
            lblBilgi.TabIndex = 2;
            lblBilgi.Text = "giriş yapan :";
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Transparent;
            btnCikis.BackgroundImage = Properties.Resources.cikiss1;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.FlatStyle = FlatStyle.Popup;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Transparent;
            btnCikis.Location = new Point(165, 965);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(103, 93);
            btnCikis.TabIndex = 23;
            btnCikis.TextAlign = ContentAlignment.BottomCenter;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = SystemColors.Highlight;
            btnGeri.BackgroundImage = Properties.Resources.geri;
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeri.ForeColor = SystemColors.Window;
            btnGeri.Location = new Point(277, 965);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(107, 93);
            btnGeri.TabIndex = 22;
            btnGeri.TextAlign = ContentAlignment.BottomCenter;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // lvPersoneller
            // 
            lvPersoneller.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvPersoneller.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lvPersoneller.FullRowSelect = true;
            lvPersoneller.GridLines = true;
            lvPersoneller.Location = new Point(25, 34);
            lvPersoneller.Name = "lvPersoneller";
            lvPersoneller.Size = new Size(565, 181);
            lvPersoneller.TabIndex = 24;
            lvPersoneller.UseCompatibleStateImageBehavior = false;
            lvPersoneller.View = View.Details;
            lvPersoneller.SelectedIndexChanged += lvPersoneller_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Personel ID";
            columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PersonelGorevId";
            columnHeader2.Width = 1;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Görevi";
            columnHeader3.Width = 185;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Adı";
            columnHeader4.Width = 185;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Soyad";
            columnHeader5.Width = 185;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(lvPersoneller);
            groupBox4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.Control;
            groupBox4.Location = new Point(745, 811);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(611, 221);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(1357, 54);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(549, 518);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.degistir2;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(43, 318);
            button2.Name = "button2";
            button2.Size = new Size(300, 165);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(0, 222);
            label9.Name = "label9";
            label9.Size = new Size(235, 42);
            label9.TabIndex = 2;
            label9.Text = "T Yeni Şifre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(24, 168);
            label10.Name = "label10";
            label10.Size = new Size(211, 42);
            label10.TabIndex = 1;
            label10.Text = "Yeni Şifre :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 225);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 51);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(497, 118);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(18, 44);
            textBox2.TabIndex = 0;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(239, 168);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 51);
            textBox3.TabIndex = 0;
            // 
            // frmAyarlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1942, 1102);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(btnCikis);
            Controls.Add(btnGeri);
            Controls.Add(lblBilgi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAyarlar";
            Text = "frmAyarlar";
            WindowState = FormWindowState.Maximized;
            Load += frmAyarlar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbPersonel;
        private Label label2;
        private Label label1;
        private TextBox txtYeniSifretekrar;
        private TextBox txtPersonelId;
        private TextBox txtYeniSifre;
        private GroupBox groupBox2;
        private Button btnBilgiDegistir;
        private Button btnSil;
        private Button btnEkle;
        private Button btnYeni;
        private TextBox txtGorevId2;
        private TextBox txtPersonelD;
        private ComboBox cbGorevi;
        private TextBox txtSifreTekrar;
        private TextBox txtSifre;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblBilgi;
        private Button btnCikis;
        private Button btnGeri;
        private ListView lvPersoneller;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}