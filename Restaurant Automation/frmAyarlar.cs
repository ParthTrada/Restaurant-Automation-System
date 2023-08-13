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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            cPersoneller cp = new cPersoneller();
            cPersonelGorev cpg = new cPersonelGorev();
            string gorev = cpg.PersonelGorevTanim(cGenel._gorevId);
            if (gorev == "Müdür")
            {
                cp.personelGetbyInformation(cbPersonel);
                cpg.PersonelGorevGetir(cbGorevi);
                cp.personelBilgileriniGetirLV(lvPersoneller);
                btnYeni.Enabled = true;
                btnSil.Enabled = false;
                btnBilgiDegistir.Enabled = false;
                btnEkle.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox4.Visible = true;
                groupBox3.Visible = false;
                txtSifre.ReadOnly = true;
                txtSifreTekrar.ReadOnly = true;
                lblBilgi.Text = "Mevki : Müdür / Yetki Sınırsız / Kullanıcı : " + cp.personelBilgiGetirIsim(cGenel._personelId);
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox4.Visible = false;
                groupBox3.Visible = true;
                lblBilgi.Text = "Mevki : Müdür / Yetki Sınırlı / Kullanıcı : " + cp.personelBilgiGetirIsim(cGenel._personelId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text.Trim() != "" || txtYeniSifretekrar.Text.Trim() != "")
            {
                if (txtYeniSifre.Text == txtYeniSifre.Text)
                {
                    if (txtPersonelId.Text != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(txtPersonelId.Text), txtYeniSifre.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme işlemi başarıyla gerçekleştirilmiştir.!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil!");
                }
            }
            else
            {
                MessageBox.Show("Şifre Alanını Boş bırakmayınız!");
            }
        }

        private void cbGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGorev c = (cPersonelGorev)cbGorevi.SelectedItem;
            txtGorevId2.Text = Convert.ToString(c.PersonelGorevId);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Enabled = false;
            btnEkle.Enabled = true;
            btnBilgiDegistir.Enabled = true;
            btnSil.Enabled = false;
            txtSifre.ReadOnly = false;
            txtSifreTekrar.ReadOnly = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cPersoneller c = new cPersoneller();
                    bool sonuc = c.personelSil(Convert.ToInt32(lvPersoneller.SelectedItems[0].Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt Başarıyla Silinmiştir.");
                        c.personelBilgileriniGetirLV(lvPersoneller);
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Silinirken bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Kayıt Seçiniz.");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.Items.Count > 0)
            {
                if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && txtSifre.Text.Trim() != "" && txtSifreTekrar.Text.Trim() != "" && txtGorevId2.Text.Trim() != "")
                {
                    if ((txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifre.Text.Length > 5 || txtSifreTekrar.Text.Length > 5))
                    {
                        cPersoneller c = new cPersoneller();
                        c.PersonelAd = txtAd.Text.Trim();
                        c.PersonelSoyad = txtSoyad.Text.Trim();
                        c.PersonelParola = txtSifreTekrar.Text.Trim();
                        c.PersonelGorevId = Convert.ToInt32(txtGorevId2.Text.Trim());
                        bool sonuc = c.personelEkle(c);

                        if (sonuc)
                        {
                            MessageBox.Show("Kayıt başarıyla eklenmiştir.");
                            c.personelBilgileriniGetirLV(lvPersoneller);

                        }
                        else
                        {
                            MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Aynı Değil,Şifre en az 6 haneli olmalı!");
                    }
                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakmayınız!");
                }
            }
            else
            {
                MessageBox.Show("Kayıt Seçiniz.");
            }
        }

        private void btnBilgiDegistir_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && txtSifre.Text.Trim() != "" && txtSifreTekrar.Text.Trim() != "" && txtGorevId2.Text.Trim() != "")
            {
                if ((txtSifreTekrar.Text.Trim() == txtSifre.Text.Trim()) && (txtSifre.Text.Length > 5 || txtSifreTekrar.Text.Length > 5))
                {
                    cPersoneller c = new cPersoneller();
                    c.PersonelAd = txtAd.Text.Trim();
                    c.PersonelSoyad = txtSoyad.Text.Trim();
                    c.PersonelParola = txtSifreTekrar.Text.Trim();
                    c.PersonelGorevId = Convert.ToInt32(txtGorevId2.Text.Trim());
                    bool sonuc = c.personelGuncelle(c, Convert.ToInt32(txtPersonelD.Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarıyla güncellenmiştir.");
                        c.personelBilgileriniGetirLV(lvPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt güncellenirken bir hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Aynı Değil");
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() != "" || textBox1.Text.Trim() != "")
            {
                if (textBox3.Text == textBox1.Text)
                {
                    if (cGenel._personelId.ToString() != "")
                    {
                        cPersoneller c = new cPersoneller();
                        bool sonuc = c.personelSifreDegistir(Convert.ToInt32(cGenel._personelId), textBox3.Text);
                        if (sonuc)
                        {
                            MessageBox.Show("Şifre Değiştirme işlemi başarıyla gerçekleştirilmiştir.!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Personel Seçiniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil!");
                }
            }
            else
            {
                MessageBox.Show("Şifre Alanını Boş bırakmayınız!");
            }
        }

        private void cbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller c = (cPersoneller)cbPersonel.SelectedItem;
            txtPersonelId.Text = Convert.ToString(c.PersonelId);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                btnSil.Enabled = true;
                btnBilgiDegistir.Enabled = true;
                txtPersonelD.Text = lvPersoneller.SelectedItems[0].SubItems[0].Text;

                cbGorevi.SelectedIndex = Convert.ToInt32(lvPersoneller.SelectedItems[0].SubItems[1].Text) - 1;
                txtAd.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text;
                txtSoyad.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
}
