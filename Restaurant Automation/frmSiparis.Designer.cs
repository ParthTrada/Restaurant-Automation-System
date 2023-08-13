namespace Restaurant_Otomasyonu
{
    partial class frmSiparis
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
            lblMasaNo = new Label();
            groupBox1 = new GroupBox();
            btnArasicak2 = new Button();
            btnMakarna4 = new Button();
            btnIcecekler8 = new Button();
            btnTatlilar7 = new Button();
            btnSalata6 = new Button();
            btnCorba1 = new Button();
            btnFastfood5 = new Button();
            btnAnaYemek3 = new Button();
            groupBox2 = new GroupBox();
            lvMenu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox3 = new GroupBox();
            lvSiparisler = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            txtAra = new TextBox();
            label2 = new Label();
            btn1 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn9 = new Button();
            btnTemizle = new Button();
            btn0 = new Button();
            txtAdet = new TextBox();
            btnCikis = new Button();
            btnGeri = new Button();
            btnOdeme = new Button();
            btnSiparis = new Button();
            btnIptal = new Button();
            lvYeniEklenenler = new ListView();
            AdisyonId = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblMasaNo
            // 
            lblMasaNo.AutoSize = true;
            lblMasaNo.BackColor = Color.Transparent;
            lblMasaNo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor = SystemColors.ButtonFace;
            lblMasaNo.Location = new Point(155, 91);
            lblMasaNo.Margin = new Padding(4, 0, 4, 0);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(93, 25);
            lblMasaNo.TabIndex = 0;
            lblMasaNo.Text = "MASA 1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnArasicak2);
            groupBox1.Controls.Add(btnMakarna4);
            groupBox1.Controls.Add(btnIcecekler8);
            groupBox1.Controls.Add(btnTatlilar7);
            groupBox1.Controls.Add(btnSalata6);
            groupBox1.Controls.Add(btnCorba1);
            groupBox1.Controls.Add(btnFastfood5);
            groupBox1.Controls.Add(btnAnaYemek3);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(155, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 709);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menü";
            // 
            // btnArasicak2
            // 
            btnArasicak2.BackgroundImage = Properties.Resources.arasicak1;
            btnArasicak2.BackgroundImageLayout = ImageLayout.Stretch;
            btnArasicak2.FlatStyle = FlatStyle.Popup;
            btnArasicak2.Location = new Point(309, 539);
            btnArasicak2.Name = "btnArasicak2";
            btnArasicak2.Size = new Size(268, 152);
            btnArasicak2.TabIndex = 7;
            btnArasicak2.UseVisualStyleBackColor = true;
            btnArasicak2.Click += btnArasicak_Click;
            // 
            // btnMakarna4
            // 
            btnMakarna4.BackColor = Color.Transparent;
            btnMakarna4.BackgroundImage = Properties.Resources.makarna1;
            btnMakarna4.BackgroundImageLayout = ImageLayout.Stretch;
            btnMakarna4.FlatStyle = FlatStyle.Popup;
            btnMakarna4.Location = new Point(6, 539);
            btnMakarna4.Name = "btnMakarna4";
            btnMakarna4.Size = new Size(297, 152);
            btnMakarna4.TabIndex = 6;
            btnMakarna4.UseVisualStyleBackColor = false;
            btnMakarna4.Click += btnMakarna_Click;
            // 
            // btnIcecekler8
            // 
            btnIcecekler8.BackgroundImage = Properties.Resources.icecekler;
            btnIcecekler8.BackgroundImageLayout = ImageLayout.Stretch;
            btnIcecekler8.FlatStyle = FlatStyle.Popup;
            btnIcecekler8.Location = new Point(309, 33);
            btnIcecekler8.Name = "btnIcecekler8";
            btnIcecekler8.Size = new Size(268, 166);
            btnIcecekler8.TabIndex = 5;
            btnIcecekler8.UseVisualStyleBackColor = true;
            btnIcecekler8.Click += btnIcecekler_Click;
            // 
            // btnTatlilar7
            // 
            btnTatlilar7.BackgroundImage = Properties.Resources.tatlilar;
            btnTatlilar7.BackgroundImageLayout = ImageLayout.Stretch;
            btnTatlilar7.FlatStyle = FlatStyle.Popup;
            btnTatlilar7.Location = new Point(6, 205);
            btnTatlilar7.Name = "btnTatlilar7";
            btnTatlilar7.Size = new Size(297, 159);
            btnTatlilar7.TabIndex = 4;
            btnTatlilar7.UseVisualStyleBackColor = true;
            btnTatlilar7.Click += btnTatlilar_Click;
            // 
            // btnSalata6
            // 
            btnSalata6.BackgroundImage = Properties.Resources.salata;
            btnSalata6.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalata6.FlatStyle = FlatStyle.Popup;
            btnSalata6.Location = new Point(309, 205);
            btnSalata6.Name = "btnSalata6";
            btnSalata6.Size = new Size(268, 158);
            btnSalata6.TabIndex = 3;
            btnSalata6.UseVisualStyleBackColor = true;
            btnSalata6.Click += btnSalata_Click;
            // 
            // btnCorba1
            // 
            btnCorba1.BackgroundImage = Properties.Resources.corba;
            btnCorba1.BackgroundImageLayout = ImageLayout.Stretch;
            btnCorba1.FlatStyle = FlatStyle.Popup;
            btnCorba1.Location = new Point(309, 369);
            btnCorba1.Name = "btnCorba1";
            btnCorba1.Size = new Size(268, 164);
            btnCorba1.TabIndex = 2;
            btnCorba1.UseVisualStyleBackColor = true;
            btnCorba1.Click += btnCorba_Click;
            // 
            // btnFastfood5
            // 
            btnFastfood5.BackgroundImage = Properties.Resources.fastfood;
            btnFastfood5.BackgroundImageLayout = ImageLayout.Stretch;
            btnFastfood5.FlatStyle = FlatStyle.Popup;
            btnFastfood5.Location = new Point(6, 370);
            btnFastfood5.Name = "btnFastfood5";
            btnFastfood5.Size = new Size(297, 163);
            btnFastfood5.TabIndex = 1;
            btnFastfood5.UseVisualStyleBackColor = true;
            btnFastfood5.Click += btnFastfood_Click;
            // 
            // btnAnaYemek3
            // 
            btnAnaYemek3.BackgroundImage = Properties.Resources.anayemek;
            btnAnaYemek3.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnaYemek3.FlatStyle = FlatStyle.Popup;
            btnAnaYemek3.Location = new Point(6, 33);
            btnAnaYemek3.Name = "btnAnaYemek3";
            btnAnaYemek3.Size = new Size(297, 166);
            btnAnaYemek3.TabIndex = 0;
            btnAnaYemek3.UseVisualStyleBackColor = true;
            btnAnaYemek3.Click += btnAnaYemek1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(lvMenu);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(754, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(434, 351);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menü";
            // 
            // lvMenu
            // 
            lvMenu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvMenu.GridLines = true;
            lvMenu.Location = new Point(6, 33);
            lvMenu.Name = "lvMenu";
            lvMenu.Size = new Size(422, 304);
            lvMenu.TabIndex = 0;
            lvMenu.UseCompatibleStateImageBehavior = false;
            lvMenu.View = View.Details;
            lvMenu.DoubleClick += lvMenu_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ürün Adı";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ürün Fiyatı";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ürün No";
            columnHeader3.Width = 130;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(lvSiparisler);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(754, 528);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(434, 339);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Siparişler";
            // 
            // lvSiparisler
            // 
            lvSiparisler.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvSiparisler.GridLines = true;
            lvSiparisler.Location = new Point(6, 33);
            lvSiparisler.Name = "lvSiparisler";
            lvSiparisler.Size = new Size(422, 288);
            lvSiparisler.TabIndex = 0;
            lvSiparisler.UseCompatibleStateImageBehavior = false;
            lvSiparisler.View = View.Details;
            lvSiparisler.DoubleClick += lvSiparisler_DoubleClick;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ürün Adı";
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ürün Adet";
            columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "UrunId";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ürün Fiyat";
            columnHeader7.Width = 105;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(424, 85);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(195, 34);
            txtAra.TabIndex = 4;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(315, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Urun No";
            // 
            // btn1
            // 
            btn1.BackColor = Color.Yellow;
            btn1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(1194, 201);
            btn1.Name = "btn1";
            btn1.Size = new Size(149, 89);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Yellow;
            btn8.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.ForeColor = SystemColors.ActiveCaptionText;
            btn8.Location = new Point(1349, 397);
            btn8.Name = "btn8";
            btn8.Size = new Size(148, 98);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Yellow;
            btn7.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.ForeColor = SystemColors.ActiveCaptionText;
            btn7.Location = new Point(1194, 397);
            btn7.Name = "btn7";
            btn7.Size = new Size(149, 98);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Yellow;
            btn6.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.ForeColor = SystemColors.ActiveCaptionText;
            btn6.Location = new Point(1503, 296);
            btn6.Name = "btn6";
            btn6.Size = new Size(151, 95);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Yellow;
            btn5.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = SystemColors.ActiveCaptionText;
            btn5.Location = new Point(1349, 296);
            btn5.Name = "btn5";
            btn5.Size = new Size(148, 95);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Yellow;
            btn4.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = SystemColors.ActiveCaptionText;
            btn4.Location = new Point(1194, 296);
            btn4.Name = "btn4";
            btn4.Size = new Size(149, 95);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Yellow;
            btn3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = SystemColors.ActiveCaptionText;
            btn3.Location = new Point(1503, 201);
            btn3.Name = "btn3";
            btn3.Size = new Size(151, 89);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Yellow;
            btn2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = SystemColors.ActiveCaptionText;
            btn2.Location = new Point(1349, 201);
            btn2.Name = "btn2";
            btn2.Size = new Size(148, 89);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Yellow;
            btn9.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = SystemColors.ActiveCaptionText;
            btn9.Location = new Point(1503, 397);
            btn9.Name = "btn9";
            btn9.Size = new Size(151, 98);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Yellow;
            btnTemizle.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnTemizle.ForeColor = SystemColors.ActiveCaptionText;
            btnTemizle.Location = new Point(1194, 501);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(303, 98);
            btnTemizle.TabIndex = 15;
            btnTemizle.Text = "C";
            btnTemizle.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Yellow;
            btn0.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.ForeColor = SystemColors.ActiveCaptionText;
            btn0.Location = new Point(1505, 501);
            btn0.Name = "btn0";
            btn0.Size = new Size(149, 98);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(1194, 116);
            txtAdet.Multiline = true;
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(460, 79);
            txtAdet.TabIndex = 17;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Transparent;
            btnCikis.BackgroundImage = Properties.Resources.cikiss1;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.FlatStyle = FlatStyle.Popup;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Transparent;
            btnCikis.Location = new Point(155, 896);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(103, 93);
            btnCikis.TabIndex = 19;
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
            btnGeri.Location = new Point(264, 896);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(107, 93);
            btnGeri.TabIndex = 18;
            btnGeri.TextAlign = ContentAlignment.BottomCenter;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnOdeme
            // 
            btnOdeme.BackgroundImage = Properties.Resources.odeme;
            btnOdeme.BackgroundImageLayout = ImageLayout.Stretch;
            btnOdeme.FlatStyle = FlatStyle.Popup;
            btnOdeme.Location = new Point(1194, 615);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new Size(274, 110);
            btnOdeme.TabIndex = 20;
            btnOdeme.UseVisualStyleBackColor = true;
            btnOdeme.Click += btnOdeme_Click;
            // 
            // btnSiparis
            // 
            btnSiparis.BackgroundImage = Properties.Resources.siparis2;
            btnSiparis.BackgroundImageLayout = ImageLayout.Stretch;
            btnSiparis.FlatStyle = FlatStyle.Popup;
            btnSiparis.Location = new Point(1474, 615);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(265, 110);
            btnSiparis.TabIndex = 21;
            btnSiparis.UseVisualStyleBackColor = true;
            btnSiparis.Click += btnSiparis_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = SystemColors.Control;
            btnIptal.BackgroundImage = Properties.Resources.iptal;
            btnIptal.BackgroundImageLayout = ImageLayout.Stretch;
            btnIptal.FlatStyle = FlatStyle.Popup;
            btnIptal.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnIptal.Location = new Point(1309, 731);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(265, 101);
            btnIptal.TabIndex = 22;
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // lvYeniEklenenler
            // 
            lvYeniEklenenler.Columns.AddRange(new ColumnHeader[] { AdisyonId, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            lvYeniEklenenler.Location = new Point(760, 873);
            lvYeniEklenenler.Name = "lvYeniEklenenler";
            lvYeniEklenenler.Size = new Size(422, 129);
            lvYeniEklenenler.TabIndex = 23;
            lvYeniEklenenler.UseCompatibleStateImageBehavior = false;
            lvYeniEklenenler.View = View.Details;
            // 
            // AdisyonId
            // 
            AdisyonId.Text = "AdisyonId";
            AdisyonId.Width = 105;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "UrunId";
            columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Adet";
            columnHeader9.Width = 55;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "MasaId";
            columnHeader10.Width = 77;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "SilinenId";
            columnHeader11.Width = 95;
            // 
            // frmSiparis
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1001);
            Controls.Add(lvYeniEklenenler);
            Controls.Add(btnIptal);
            Controls.Add(btnSiparis);
            Controls.Add(btnOdeme);
            Controls.Add(btnCikis);
            Controls.Add(btnGeri);
            Controls.Add(txtAdet);
            Controls.Add(btn0);
            Controls.Add(btnTemizle);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn1);
            Controls.Add(label2);
            Controls.Add(txtAra);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblMasaNo);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmSiparis";
            Text = "frmSiparis";
            WindowState = FormWindowState.Maximized;
            Load += frmSiparis_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMasaNo;
        private GroupBox groupBox1;
        private Button btnAnaYemek3;
        private Button btnArasicak2;
        private Button btnMakarna4;
        private Button btnIcecekler8;
        private Button btnTatlilar7;
        private Button btnSalata6;
        private Button btnCorba1;
        private Button btnFastfood5;
        private GroupBox groupBox2;
        private ListView lvMenu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox groupBox3;
        private ListView lvSiparisler;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private TextBox txtAra;
        private Label label2;
        private Button btn1;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn9;
        private Button btnTemizle;
        private Button btn0;
        private TextBox txtAdet;
        private Button btnCikis;
        private Button btnGeri;
        private Button btnOdeme;
        private Button btnSiparis;
        private Button btnIptal;
        private ListView lvYeniEklenenler;
        private ColumnHeader AdisyonId;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}