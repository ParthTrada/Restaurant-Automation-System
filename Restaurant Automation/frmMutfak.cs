using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Otomasyonu
{
    public partial class frmMutfak : Form
    {
        public frmMutfak()
        {
            InitializeComponent();
        }

        private void frmMutfak_Load(object sender, EventArgs e)
        {
            cUrunCesitleri Anakategori = new cUrunCesitleri();
            Anakategori.urunCesitleriniGetir(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;

            label1.Visible = false;
            txtArama.Visible = false;
            rbAltkategori.Checked = true;
            cUrunler c = new cUrunler();
            c.urunleriListele(lvGidaListesi);

        }
        private void Temizle()
        {
            txtGidaAdi.Clear();
            txtGidaFiyati.Clear();
            txtGidaAdi.Text = string.Format("{0:##0.00}", 0);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                if (txtGidaAdi.Text.Trim() == "" || txtGidaFiyati.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gida Adi Fiyatı ve kategori seçilmemiştir.", "Dikkat, Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    cUrunler c = new cUrunler();
                    c.Fiyat = Convert.ToDecimal(txtGidaFiyati.Text);
                    c.Urunad = txtGidaAdi.Text;
                    c.Aciklama = "ürün eklendi";
                    c.Urunturno = urunturNo;
                    int sonuc = c.urunEkle(c);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Eklenmiştir");
                        yenile();
                        Temizle();
                    }
                }
            }
            else
            {
                if (txtKategoriAd.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori ismi giriniz.", "Dikkat,Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri gida = new cUrunCesitleri();
                    gida.TurAd = txtKategoriAd.Text;
                    gida.Aciklama = txtAciklama.Text;
                    int sonuc = gida.urunKategoriEkle(gida);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori Eklenmiştir");
                        yenile();
                        Temizle();
                    }
                }
            }
        }
        int urunturNo = 0;
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            if (cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
            {
                u.urunleriListele(lvGidaListesi);
            }
            else
            {
                cUrunCesitleri cesit = (cUrunCesitleri)cbKategoriler.SelectedItem;
                urunturNo = cesit.UrunTurNo;
                u.urunleriListeleByUrunAdi(lvGidaListesi, urunturNo);
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                if (txtGidaAdi.Text.Trim() == "" || txtGidaFiyati.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "Tüm Kategoriler")
                {
                    MessageBox.Show("Gida Adi Fiyatı ve kategori seçilmemiştir.", "Dikkat, Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    cUrunler c = new cUrunler();
                    c.Fiyat = Convert.ToDecimal(txtGidaFiyati.Text);
                    c.Urunad = txtGidaAdi.Text;
                    c.Urunid = Convert.ToInt32(txtUrunId.Text);

                    c.Aciklama = "ürün güncellendi";
                    c.Urunturno = urunturNo;
                    int sonuc = c.urunGuncelle(c);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Ürün Güncellenmiştir.");
                        yenile();
                        cbKategoriler_SelectedIndexChanged(sender, e);
                        Temizle();
                    }
                }
            }
            else
            {
                if (txtKategoriID.Text.Trim() == "")
                {
                    MessageBox.Show("Lütfen bir kategori seçiniz.", "Dikkat,Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cUrunCesitleri gida = new cUrunCesitleri();
                    gida.TurAd = txtKategoriAd.Text;
                    gida.Aciklama = txtAciklama.Text;
                    gida.UrunTurNo = Convert.ToInt32(txtKategoriID.Text);
                    int sonuc = gida.urunKategoriGuncelle(gida);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Kategori Güncellenmiştir");
                        yenile();
                        Temizle();
                    }
                }
            }
        }

        private void lvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKategoriler.SelectedItems.Count > 0)
            {
                txtKategoriAd.Text = lvKategoriler.SelectedItems[0].SubItems[1].Text;
                txtKategoriID.Text = lvKategoriler.SelectedItems[0].SubItems[0].Text;
                txtAciklama.Text = lvKategoriler.SelectedItems[0].SubItems[2].Text;
                //cbKategoriler.SelectedIndex=Convert.ToInt32(txtUrunId.Text);
            }
        }

        private void lvGidaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGidaListesi.SelectedItems.Count > 0)
            {
                txtGidaAdi.Text = lvGidaListesi.SelectedItems[0].SubItems[3].Text;
                txtGidaFiyati.Text = lvGidaListesi.SelectedItems[0].SubItems[4].Text;
                txtUrunId.Text = lvGidaListesi.SelectedItems[0].SubItems[0].Text;
                //cbKategoriler.SelectedIndex=Convert.ToInt32(txtUrunId.Text);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                if (lvGidaListesi.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Ürün Silmekte Emin misiniz?", "Dikkat, Bilgiler Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunler c = new cUrunler();
                        c.Urunid = Convert.ToInt32(txtUrunId.Text);
                        int sonuc = c.urunSil(c,1);
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Ürün Silinmiştir.");

                            
                            yenile();
                            Temizle();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ürün silmek için bir ürün seçiniz.?", "Dikkat, Ürün seçmediniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (lvKategoriler.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Kategori Silmekte Emin misiniz?", "Dikkat, Bilgiler Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunCesitleri uc = new cUrunCesitleri();
                        int sonuc = uc.urunKategoriSil(Convert.ToInt32(txtKategoriID.Text)); ;
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Ürün Silinmiştir.");
                           cUrunler c=new cUrunler();
                            c.Urunid = Convert.ToInt32(txtKategoriID.Text);
                            c.urunSil(c, 0);
                            yenile();
                            Temizle();
                        }
                    }
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtArama.Visible = true;

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                cUrunler u = new cUrunler();
                u.urunleriListeleByUrunAdi(lvGidaListesi, txtArama.Text);
            }
            else
            {
                cUrunCesitleri uc = new cUrunCesitleri();
                uc.urunCesitleriniGetir(lvKategoriler, txtArama.Text);
            }
        }

        private void rbAltkategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = true;
            panelAnaKategori.Visible = false;
            lvKategoriler.Visible = false;
            lvGidaListesi.Visible = true;
            yenile();
        }

        private void rbAnaKategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = false;
            panelAnaKategori.Visible = true;
            lvKategoriler.Visible = true;
            lvGidaListesi.Visible = false;
            //cUrunCesitleri uc = new cUrunCesitleri();
            //uc.urunCesitleriniGetir(lvKategoriler);
        }
        private void yenile()
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.urunCesitleriniGetir(cbKategoriler);
            cbKategoriler.Items.Insert(0, "Tüm Kategoriler");
            cbKategoriler.SelectedIndex = 0;
            uc.urunCesitleriniGetir(lvKategoriler);
            cUrunler c = new cUrunler();
            c.urunleriListele(lvGidaListesi);
        }
    }
}
