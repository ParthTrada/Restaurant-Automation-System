namespace Restaurant_Otomasyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        cGenel gnl = new cGenel();

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çýkmak Ýstediðinize Emin Misiniz?", "Uyarý !!!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmGiris_Load_1(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetbyInformation(cbKullanici);
        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            bool result = p.personelEntryControl(txtSifre.Text, cGenel._personelId);
            if (result)
            {
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Giriþ Yaptý";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Þifreniz Yanlýþ?", "Uyarý !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}