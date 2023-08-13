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
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
        cSiparis cs = new cSiparis(); int odemeTurId = 0;
        private void frmOdeme_Load(object sender, EventArgs e)
        {
                if (cGenel._ServisTurNo == 1)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));
                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblFiyat.Text = string.Format("{0:0.000}", toplam);
                    lblAraToplam.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblFiyat.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = false;
                txtIndirimTutari.Clear();
            }
            else if (cGenel._ServisTurNo == 2)
            {
                lblAdisyonId.Text = cGenel._AdisyonId;
                cPaketler pc = new cPaketler();
                odemeTurId = pc.OdemeTurIdGetir(Convert.ToInt32(lblAdisyonId.Text));
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));

                if (odemeTurId == 1)
                {
                    rbNakit.Checked = true;
                }
                else if (odemeTurId == 2)
                {
                    rbKrediKarti.Checked = true;
                }
                else if (odemeTurId == 3)
                {
                    rbTicket.Checked = true;
                }

                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblFiyat.Text = string.Format("{0:0.000}", toplam);
                    lblAraToplam.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblFiyat.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = false;
                txtIndirimTutari.Clear();
            }
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
            else
            {
                gbIndirim.Visible = false;
                txtIndirimTutari.Clear();
            }
        }

        private void txtIndirimTutari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtIndirimTutari.Text) < Convert.ToDecimal(lblFiyat.Text))
                {
                    try
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirimTutari.Text));
                    }
                    catch (Exception)
                    {
                        lblIndirim.Text = string.Format("{0:0.000}");
                    }
                }
                else
                {
                    MessageBox.Show("İndirim Tutarı Toplam Tutardan Fazla Olmaz !!!");
                }
            }
            catch (Exception)
            {
                lblIndirim.Text = string.Format("{0:0.000}", 0);
            }
        }
        cMasalar masalar = new cMasalar();
        cRezervasyon rezerve = new cRezervasyon();
        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text) > 0)
            {
                decimal fiyat = 0;
                lblAraToplam.Text = lblFiyat.Text;
                fiyat = Convert.ToDecimal(lblAraToplam.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblAraToplam.Text = string.Format("{0:0.000}", fiyat);
            }
            else
            {
                lblAraToplam.Text = lblFiyat.Text;
            }
            decimal kdv = Convert.ToDecimal(lblAraToplam.Text) * 18 / 100;
            lblKdv.Text = string.Format("{0:0.000}", kdv);
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            if (cGenel._ServisTurNo == 1)
            {
                int masaid = masalar.TableGetbyNumber(cGenel._ButtonValue);
                int musteriId = 0;

                if (masalar.TableGetbyState(masaid, 4) == true)
                {
                    musteriId = rezerve.getByClientIdFromRezervasyon(masaid);
                }
                else
                {
                    musteriId = 1;
                }
                int odemeTurId = 0;
                if (rbNakit.Checked)
                {
                    odemeTurId = 1;
                }
                else if (rbKrediKarti.Checked)
                {
                    odemeTurId = 2;
                }
                else if (rbTicket.Checked)
                {
                    odemeTurId = 3;
                }
                cOdeme odeme = new cOdeme();
                odeme.AdisyonID = Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = odemeTurId;
                odeme.MusteriId = musteriId;
                odeme.AraToplam = Convert.ToDecimal(lblAraToplam.Text);
                odeme.Kdvtutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblFiyat.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);
                bool result = odeme.billClose(odeme);
                if (result)
                {
                    MessageBox.Show("Hesap kapatılmıştır.");
                    masalar.setChangeTableState(Convert.ToString(masaid), 1);
                   

                    cAdisyon a = new cAdisyon();
                    a.adisyonkapat(Convert.ToInt32(lblAdisyonId.Text), 0);
                    this.Close();
                    frmMasalar frm = new frmMasalar();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Hesap Kapatılırken bir hata oluştur. Lütfen yetkililere bildiriniz.");
                }

            }
            else if(cGenel._ServisTurNo == 1)
            {
                cOdeme odeme = new cOdeme();
                odeme.AdisyonID = Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = odemeTurId;
                odeme.MusteriId = 1;
                odeme.AraToplam = Convert.ToDecimal(lblAraToplam.Text);
                odeme.Kdvtutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblFiyat.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);

                bool result = odeme.billClose(odeme);
                if (result)
                {
                    MessageBox.Show("Hesap kapatılmıştır.");
                    
                    
                    cPaketler p=new cPaketler();
                    p.OrderServiceClose(Convert.ToInt32(lblAdisyonId.Text));

                 

                    this.Close();
                    frmMasalar frm = new frmMasalar();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Hesap Kapatılırken bir hata oluştur. Lütfen yetkililere bildiriniz.");
                }
            }
        }

        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();


        }
        Font Baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("RESTAURANT OTOMASYON", Baslik, sb, 350, 100, st);
            e.Graphics.DrawString("--------------------------------------", altBaslik, sb, 350, 120, st);
            e.Graphics.DrawString("Ürün Adı                  Adet          Fiyat", altBaslik, sb, 150, 250, st);
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerik, sb, 350, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text, icerik, sb, 420, 300 + i * 30, st);
            }
            e.Graphics.DrawString("--------------------------------------", altBaslik, sb, 150, 300 + 30 * lvUrunler.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutarı      :-----------------" + lblIndirim.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 1), st);
            e.Graphics.DrawString("KDV Tutarı          :-----------------" + lblKdv.Text + " TL", altBaslik, sb, 250, 300 + 30*(lvUrunler.Items.Count + 2), st);
            e.Graphics.DrawString("Toplam Tutar        :-----------------" + lblFiyat.Text + " TL", altBaslik, sb, 250, 300 + 30*(lvUrunler.Items.Count + 3), st);
            e.Graphics.DrawString("Ödediğiniz Tutar    :-----------------" + lblAraToplam.Text + " TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 4), st);



        }

        private void lvUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
