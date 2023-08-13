namespace Restaurant_Otomasyonu
{
    partial class frmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
            lvUrunler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1 = new GroupBox();
            chkIndirim = new CheckBox();
            label1 = new Label();
            gbIndirim = new GroupBox();
            label2 = new Label();
            txtIndirimTutari = new TextBox();
            groupBox3 = new GroupBox();
            label14 = new Label();
            lblAraToplam = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            lblFiyat = new Label();
            lblKdv = new Label();
            lblIndirim = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox4 = new GroupBox();
            rbTicket = new RadioButton();
            rbKrediKarti = new RadioButton();
            rbNakit = new RadioButton();
            btnGeri = new Button();
            btnCikis = new Button();
            btnHesapOzeti = new Button();
            btnHesapKapat = new Button();
            lblAdisyonId = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            groupBox1.SuspendLayout();
            gbIndirim.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lvUrunler
            // 
            lvUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvUrunler.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lvUrunler.GridLines = true;
            lvUrunler.Location = new Point(82, 236);
            lvUrunler.Name = "lvUrunler";
            lvUrunler.Size = new Size(748, 360);
            lvUrunler.TabIndex = 0;
            lvUrunler.UseCompatibleStateImageBehavior = false;
            lvUrunler.View = View.Details;
            lvUrunler.SelectedIndexChanged += lvUrunler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Urun Adı";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adet";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "UrunId";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fiyat";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SatisId";
            columnHeader5.Width = 140;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(chkIndirim);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(836, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 165);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Özel İndirim";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // chkIndirim
            // 
            chkIndirim.AutoSize = true;
            chkIndirim.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            chkIndirim.ForeColor = SystemColors.Control;
            chkIndirim.Location = new Point(22, 72);
            chkIndirim.Name = "chkIndirim";
            chkIndirim.Size = new Size(202, 33);
            chkIndirim.TabIndex = 0;
            chkIndirim.Text = "İndirim Uygula";
            chkIndirim.UseVisualStyleBackColor = true;
            chkIndirim.CheckedChanged += chkIndirim_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(82, 201);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 2;
            label1.Text = "Siparişler";
            // 
            // gbIndirim
            // 
            gbIndirim.BackColor = Color.Transparent;
            gbIndirim.Controls.Add(label2);
            gbIndirim.Controls.Add(txtIndirimTutari);
            gbIndirim.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            gbIndirim.ForeColor = SystemColors.Control;
            gbIndirim.Location = new Point(1111, 236);
            gbIndirim.Name = "gbIndirim";
            gbIndirim.Size = new Size(250, 165);
            gbIndirim.TabIndex = 3;
            gbIndirim.TabStop = false;
            gbIndirim.Text = "Özel Aktivite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(228, 29);
            label2.TabIndex = 1;
            label2.Text = "İndirim Tutarı Giriniz";
            // 
            // txtIndirimTutari
            // 
            txtIndirimTutari.Location = new Point(6, 100);
            txtIndirimTutari.Name = "txtIndirimTutari";
            txtIndirimTutari.Size = new Size(238, 38);
            txtIndirimTutari.TabIndex = 0;
            txtIndirimTutari.TextChanged += txtIndirimTutari_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(lblAraToplam);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(lblFiyat);
            groupBox3.Controls.Add(lblKdv);
            groupBox3.Controls.Add(lblIndirim);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(143, 620);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(313, 272);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ödeme Bilgileri";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(270, 209);
            label14.Name = "label14";
            label14.Size = new Size(39, 31);
            label14.TabIndex = 11;
            label14.Text = "TL";
            // 
            // lblAraToplam
            // 
            lblAraToplam.AutoSize = true;
            lblAraToplam.Location = new Point(180, 209);
            lblAraToplam.Name = "lblAraToplam";
            lblAraToplam.Size = new Size(27, 31);
            lblAraToplam.TabIndex = 10;
            lblAraToplam.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 209);
            label12.Name = "label12";
            label12.Size = new Size(136, 31);
            label12.TabIndex = 9;
            label12.Text = "Ara Toplam";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(270, 157);
            label11.Name = "label11";
            label11.Size = new Size(39, 31);
            label11.TabIndex = 8;
            label11.Text = "TL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(270, 109);
            label10.Name = "label10";
            label10.Size = new Size(39, 31);
            label10.TabIndex = 7;
            label10.Text = "TL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(270, 57);
            label9.Name = "label9";
            label9.Size = new Size(39, 31);
            label9.TabIndex = 6;
            label9.Text = "TL";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new Point(180, 157);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(27, 31);
            lblFiyat.TabIndex = 5;
            lblFiyat.Text = "0";
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Location = new Point(180, 109);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new Size(27, 31);
            lblKdv.TabIndex = 4;
            lblKdv.Text = "0";
            lblKdv.Click += label7_Click;
            // 
            // lblIndirim
            // 
            lblIndirim.AutoSize = true;
            lblIndirim.Location = new Point(180, 57);
            lblIndirim.Name = "lblIndirim";
            lblIndirim.Size = new Size(27, 31);
            lblIndirim.TabIndex = 3;
            lblIndirim.Text = "0";
            lblIndirim.TextChanged += lblIndirim_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 157);
            label5.Name = "label5";
            label5.Size = new Size(66, 31);
            label5.TabIndex = 2;
            label5.Text = "Fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 109);
            label4.Name = "label4";
            label4.Size = new Size(61, 31);
            label4.TabIndex = 1;
            label4.Text = "KDV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 57);
            label3.Name = "label3";
            label3.Size = new Size(93, 31);
            label3.TabIndex = 0;
            label3.Text = "İndirim";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(rbTicket);
            groupBox4.Controls.Add(rbKrediKarti);
            groupBox4.Controls.Add(rbNakit);
            groupBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.Control;
            groupBox4.Location = new Point(487, 620);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(313, 272);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ödeme Türü";
            // 
            // rbTicket
            // 
            rbTicket.AutoSize = true;
            rbTicket.Location = new Point(51, 180);
            rbTicket.Name = "rbTicket";
            rbTicket.Size = new Size(100, 35);
            rbTicket.TabIndex = 2;
            rbTicket.TabStop = true;
            rbTicket.Text = "Ticket";
            rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbKrediKarti
            // 
            rbKrediKarti.AutoSize = true;
            rbKrediKarti.Location = new Point(51, 119);
            rbKrediKarti.Name = "rbKrediKarti";
            rbKrediKarti.Size = new Size(151, 35);
            rbKrediKarti.TabIndex = 1;
            rbKrediKarti.TabStop = true;
            rbKrediKarti.Text = "Kredi Kartı";
            rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            rbNakit.AutoSize = true;
            rbNakit.Location = new Point(51, 55);
            rbNakit.Name = "rbNakit";
            rbNakit.Size = new Size(94, 35);
            rbNakit.TabIndex = 0;
            rbNakit.TabStop = true;
            rbNakit.Text = "Nakit";
            rbNakit.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = SystemColors.Highlight;
            btnGeri.BackgroundImage = Properties.Resources.geri;
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeri.ForeColor = SystemColors.Window;
            btnGeri.Location = new Point(243, 944);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(107, 93);
            btnGeri.TabIndex = 19;
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
            btnCikis.Location = new Point(113, 944);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(103, 93);
            btnCikis.TabIndex = 20;
            btnCikis.TextAlign = ContentAlignment.BottomCenter;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnHesapOzeti
            // 
            btnHesapOzeti.BackgroundImage = Properties.Resources.hesapOzeti1;
            btnHesapOzeti.BackgroundImageLayout = ImageLayout.Stretch;
            btnHesapOzeti.FlatStyle = FlatStyle.Popup;
            btnHesapOzeti.Location = new Point(884, 477);
            btnHesapOzeti.Name = "btnHesapOzeti";
            btnHesapOzeti.Size = new Size(268, 158);
            btnHesapOzeti.TabIndex = 21;
            btnHesapOzeti.UseVisualStyleBackColor = true;
            btnHesapOzeti.Click += btnHesapOzeti_Click;
            // 
            // btnHesapKapat
            // 
            btnHesapKapat.BackgroundImage = Properties.Resources.hesapKapat1;
            btnHesapKapat.BackgroundImageLayout = ImageLayout.Stretch;
            btnHesapKapat.FlatStyle = FlatStyle.Popup;
            btnHesapKapat.Location = new Point(884, 702);
            btnHesapKapat.Name = "btnHesapKapat";
            btnHesapKapat.Size = new Size(268, 158);
            btnHesapKapat.TabIndex = 22;
            btnHesapKapat.UseVisualStyleBackColor = true;
            btnHesapKapat.Click += btnHesapKapat_Click;
            // 
            // lblAdisyonId
            // 
            lblAdisyonId.AutoSize = true;
            lblAdisyonId.BackColor = Color.Transparent;
            lblAdisyonId.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdisyonId.ForeColor = Color.Red;
            lblAdisyonId.Location = new Point(243, 201);
            lblAdisyonId.Name = "lblAdisyonId";
            lblAdisyonId.Size = new Size(37, 32);
            lblAdisyonId.TabIndex = 23;
            lblAdisyonId.Text = "Id";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // frmOdeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1547, 1102);
            Controls.Add(lblAdisyonId);
            Controls.Add(btnHesapKapat);
            Controls.Add(btnHesapOzeti);
            Controls.Add(btnCikis);
            Controls.Add(btnGeri);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(gbIndirim);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(lvUrunler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOdeme";
            Text = "frmOdeme";
            WindowState = FormWindowState.Maximized;
            Load += frmOdeme_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbIndirim.ResumeLayout(false);
            gbIndirim.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvUrunler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox1;
        private CheckBox chkIndirim;
        private Label label1;
        private GroupBox gbIndirim;
        private Label label2;
        private TextBox txtIndirimTutari;
        private GroupBox groupBox3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label lblFiyat;
        private Label lblKdv;
        private Label lblIndirim;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox4;
        private Label label14;
        private Label lblAraToplam;
        private Label label12;
        private RadioButton rbTicket;
        private RadioButton rbKrediKarti;
        private RadioButton rbNakit;
        private Button btnGeri;
        private Button btnCikis;
        private Button btnHesapOzeti;
        private Button btnHesapKapat;
        private Label lblAdisyonId;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
    }
}