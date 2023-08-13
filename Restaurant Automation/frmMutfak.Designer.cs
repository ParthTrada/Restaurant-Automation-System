namespace Restaurant_Otomasyonu
{
    partial class frmMutfak
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
            lvKategoriler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lvGidaListesi = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            btnEkle = new Button();
            btnDegistir = new Button();
            btnBul = new Button();
            btnSil = new Button();
            label1 = new Label();
            txtArama = new TextBox();
            panelUrun = new Panel();
            txtUrunId = new TextBox();
            cbKategoriler = new ComboBox();
            txtGidaFiyati = new TextBox();
            label4 = new Label();
            txtGidaAdi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panelAnaKategori = new Panel();
            txtKategoriID = new TextBox();
            txtAciklama = new TextBox();
            label6 = new Label();
            txtKategoriAd = new TextBox();
            label5 = new Label();
            rbAltkategori = new RadioButton();
            rbAnaKategori = new RadioButton();
            btnGeri = new Button();
            btnCikis = new Button();
            panelUrun.SuspendLayout();
            panelAnaKategori.SuspendLayout();
            SuspendLayout();
            // 
            // lvKategoriler
            // 
            lvKategoriler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvKategoriler.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lvKategoriler.FullRowSelect = true;
            lvKategoriler.GridLines = true;
            lvKategoriler.Location = new Point(669, 548);
            lvKategoriler.Name = "lvKategoriler";
            lvKategoriler.Size = new Size(755, 312);
            lvKategoriler.TabIndex = 0;
            lvKategoriler.UseCompatibleStateImageBehavior = false;
            lvKategoriler.View = View.Details;
            lvKategoriler.SelectedIndexChanged += lvKategoriler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kategori";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Açıklama";
            columnHeader3.Width = 300;
            // 
            // lvGidaListesi
            // 
            lvGidaListesi.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            lvGidaListesi.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lvGidaListesi.FullRowSelect = true;
            lvGidaListesi.GridLines = true;
            lvGidaListesi.Location = new Point(702, 548);
            lvGidaListesi.Name = "lvGidaListesi";
            lvGidaListesi.Size = new Size(696, 312);
            lvGidaListesi.TabIndex = 1;
            lvGidaListesi.UseCompatibleStateImageBehavior = false;
            lvGidaListesi.View = View.Details;
            lvGidaListesi.SelectedIndexChanged += lvGidaListesi_SelectedIndexChanged;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Urun Id";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "UrunTurNo";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Kategori";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Urun Adı";
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Fiyatı";
            columnHeader11.Width = 150;
            // 
            // btnEkle
            // 
            btnEkle.AccessibleRole = AccessibleRole.None;
            btnEkle.BackColor = SystemColors.Control;
            btnEkle.BackgroundImage = Properties.Resources.ekle;
            btnEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnEkle.FlatStyle = FlatStyle.Popup;
            btnEkle.Location = new Point(512, 383);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(261, 150);
            btnEkle.TabIndex = 2;
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.AccessibleRole = AccessibleRole.None;
            btnDegistir.BackColor = SystemColors.Control;
            btnDegistir.BackgroundImage = Properties.Resources.degistir;
            btnDegistir.BackgroundImageLayout = ImageLayout.Stretch;
            btnDegistir.FlatStyle = FlatStyle.Popup;
            btnDegistir.Location = new Point(779, 383);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(261, 150);
            btnDegistir.TabIndex = 3;
            btnDegistir.UseVisualStyleBackColor = false;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnBul
            // 
            btnBul.AccessibleRole = AccessibleRole.None;
            btnBul.BackColor = SystemColors.Control;
            btnBul.BackgroundImage = Properties.Resources.bul;
            btnBul.BackgroundImageLayout = ImageLayout.Stretch;
            btnBul.FlatStyle = FlatStyle.Popup;
            btnBul.Location = new Point(1046, 383);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(261, 150);
            btnBul.TabIndex = 4;
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click;
            // 
            // btnSil
            // 
            btnSil.AccessibleRole = AccessibleRole.None;
            btnSil.BackColor = SystemColors.Control;
            btnSil.BackgroundImage = Properties.Resources.sil;
            btnSil.BackgroundImageLayout = ImageLayout.Stretch;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Location = new Point(1313, 383);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(261, 150);
            btnSil.TabIndex = 5;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(682, 326);
            label1.Name = "label1";
            label1.Size = new Size(442, 42);
            label1.TabIndex = 6;
            label1.Text = "Aramak İstediğiniz Ürün : ";
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtArama.Location = new Point(1130, 323);
            txtArama.Multiline = true;
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(316, 53);
            txtArama.TabIndex = 7;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // panelUrun
            // 
            panelUrun.BackColor = Color.Transparent;
            panelUrun.Controls.Add(txtUrunId);
            panelUrun.Controls.Add(cbKategoriler);
            panelUrun.Controls.Add(txtGidaFiyati);
            panelUrun.Controls.Add(label4);
            panelUrun.Controls.Add(txtGidaAdi);
            panelUrun.Controls.Add(label3);
            panelUrun.Controls.Add(label2);
            panelUrun.Location = new Point(717, 94);
            panelUrun.Name = "panelUrun";
            panelUrun.Size = new Size(692, 179);
            panelUrun.TabIndex = 8;
            // 
            // txtUrunId
            // 
            txtUrunId.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUrunId.Location = new Point(632, 79);
            txtUrunId.Multiline = true;
            txtUrunId.Name = "txtUrunId";
            txtUrunId.Size = new Size(48, 42);
            txtUrunId.TabIndex = 14;
            // 
            // cbKategoriler
            // 
            cbKategoriler.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbKategoriler.FormattingEnabled = true;
            cbKategoriler.Location = new Point(321, 23);
            cbKategoriler.Name = "cbKategoriler";
            cbKategoriler.Size = new Size(302, 50);
            cbKategoriler.TabIndex = 13;
            cbKategoriler.SelectedIndexChanged += cbKategoriler_SelectedIndexChanged;
            // 
            // txtGidaFiyati
            // 
            txtGidaFiyati.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtGidaFiyati.Location = new Point(322, 130);
            txtGidaFiyati.Multiline = true;
            txtGidaFiyati.Name = "txtGidaFiyati";
            txtGidaFiyati.Size = new Size(301, 45);
            txtGidaFiyati.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(90, 130);
            label4.Name = "label4";
            label4.Size = new Size(226, 42);
            label4.TabIndex = 11;
            label4.Text = "Gıda Fiyatı : ";
            // 
            // txtGidaAdi
            // 
            txtGidaAdi.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtGidaAdi.Location = new Point(322, 79);
            txtGidaAdi.Multiline = true;
            txtGidaAdi.Name = "txtGidaAdi";
            txtGidaAdi.Size = new Size(301, 45);
            txtGidaAdi.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(125, 79);
            label3.Name = "label3";
            label3.Size = new Size(191, 42);
            label3.TabIndex = 9;
            label3.Text = "Gıda Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(13, 25);
            label2.Name = "label2";
            label2.Size = new Size(303, 42);
            label2.TabIndex = 7;
            label2.Text = "Gıda Kategorisi : ";
            // 
            // panelAnaKategori
            // 
            panelAnaKategori.BackColor = Color.Transparent;
            panelAnaKategori.Controls.Add(txtKategoriID);
            panelAnaKategori.Controls.Add(txtAciklama);
            panelAnaKategori.Controls.Add(label6);
            panelAnaKategori.Controls.Add(txtKategoriAd);
            panelAnaKategori.Controls.Add(label5);
            panelAnaKategori.Location = new Point(621, 97);
            panelAnaKategori.Name = "panelAnaKategori";
            panelAnaKategori.Size = new Size(926, 141);
            panelAnaKategori.TabIndex = 9;
            // 
            // txtKategoriID
            // 
            txtKategoriID.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtKategoriID.Location = new Point(576, 80);
            txtKategoriID.Multiline = true;
            txtKategoriID.Name = "txtKategoriID";
            txtKategoriID.Size = new Size(28, 45);
            txtKategoriID.TabIndex = 19;
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAciklama.Location = new Point(258, 80);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(301, 45);
            txtAciklama.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(63, 80);
            label6.Name = "label6";
            label6.Size = new Size(189, 42);
            label6.TabIndex = 17;
            label6.Text = "Açıklama :";
            // 
            // txtKategoriAd
            // 
            txtKategoriAd.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtKategoriAd.Location = new Point(258, 29);
            txtKategoriAd.Multiline = true;
            txtKategoriAd.Name = "txtKategoriAd";
            txtKategoriAd.Size = new Size(301, 45);
            txtKategoriAd.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(11, 29);
            label5.Name = "label5";
            label5.Size = new Size(241, 42);
            label5.TabIndex = 15;
            label5.Text = "Kategori Adı :";
            // 
            // rbAltkategori
            // 
            rbAltkategori.AutoSize = true;
            rbAltkategori.Location = new Point(854, 64);
            rbAltkategori.Name = "rbAltkategori";
            rbAltkategori.Size = new Size(92, 24);
            rbAltkategori.TabIndex = 10;
            rbAltkategori.TabStop = true;
            rbAltkategori.Text = "Ürün Ekle";
            rbAltkategori.UseVisualStyleBackColor = true;
            rbAltkategori.CheckedChanged += rbAltkategori_CheckedChanged;
            // 
            // rbAnaKategori
            // 
            rbAnaKategori.AutoSize = true;
            rbAnaKategori.Location = new Point(1064, 64);
            rbAnaKategori.Name = "rbAnaKategori";
            rbAnaKategori.Size = new Size(153, 24);
            rbAnaKategori.TabIndex = 11;
            rbAnaKategori.TabStop = true;
            rbAnaKategori.Text = "Ürün Kategori Ekle";
            rbAnaKategori.UseVisualStyleBackColor = true;
            rbAnaKategori.CheckedChanged += rbAnaKategori_CheckedChanged;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = SystemColors.Highlight;
            btnGeri.BackgroundImage = Properties.Resources.geri;
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeri.ForeColor = SystemColors.Window;
            btnGeri.Location = new Point(140, 916);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(107, 93);
            btnGeri.TabIndex = 20;
            btnGeri.TextAlign = ContentAlignment.BottomCenter;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Transparent;
            btnCikis.BackgroundImage = Properties.Resources.cikiss1;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.FlatStyle = FlatStyle.Popup;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Transparent;
            btnCikis.Location = new Point(28, 916);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(103, 93);
            btnCikis.TabIndex = 21;
            btnCikis.TextAlign = ContentAlignment.BottomCenter;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // frmMutfak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1701, 1021);
            Controls.Add(btnCikis);
            Controls.Add(btnGeri);
            Controls.Add(rbAnaKategori);
            Controls.Add(rbAltkategori);
            Controls.Add(panelAnaKategori);
            Controls.Add(panelUrun);
            Controls.Add(txtArama);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnBul);
            Controls.Add(btnDegistir);
            Controls.Add(btnEkle);
            Controls.Add(lvGidaListesi);
            Controls.Add(lvKategoriler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMutfak";
            Text = "frmMutfak";
            WindowState = FormWindowState.Maximized;
            Load += frmMutfak_Load;
            panelUrun.ResumeLayout(false);
            panelUrun.PerformLayout();
            panelAnaKategori.ResumeLayout(false);
            panelAnaKategori.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvKategoriler;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lvGidaListesi;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button btnEkle;
        private Button btnDegistir;
        private Button btnBul;
        private Button btnSil;
        private Label label1;
        private TextBox txtArama;
        private Panel panelUrun;
        private TextBox txtUrunId;
        private ComboBox cbKategoriler;
        private TextBox txtGidaFiyati;
        private Label label4;
        private TextBox txtGidaAdi;
        private Label label3;
        private Label label2;
        private Panel panelAnaKategori;
        private TextBox txtKategoriID;
        private TextBox txtAciklama;
        private Label label6;
        private TextBox txtKategoriAd;
        private Label label5;
        private RadioButton rbAltkategori;
        private RadioButton rbAnaKategori;
        private Button btnGeri;
        private Button btnCikis;
        private ColumnHeader columnHeader1;
    }
}