using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Otomasyonu
{
    class cOdeme
    {
        cGenel gnl=new cGenel();
        private int _OdemeID;
        private int _AdisyonID;
        private int _OdemeTurId;
        private decimal _AraToplam;
        private decimal _Indirim;
        private decimal _Kdvtutari;
        private decimal _GenelToplam;
        private DateTime _Tarih;
        private int _MusteriId;

        public int OdemeID { get => _OdemeID; set => _OdemeID = value; }
        public int AdisyonID { get => _AdisyonID; set => _AdisyonID = value; }
        public int OdemeTurId { get => _OdemeTurId; set => _OdemeTurId = value; }
        public decimal AraToplam { get => _AraToplam; set => _AraToplam = value; }
        public decimal Indirim { get => _Indirim; set => _Indirim = value; }
        public decimal Kdvtutari { get => _Kdvtutari; set => _Kdvtutari = value; }
        public decimal GenelToplam { get => _GenelToplam; set => _GenelToplam = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
        //Müşterinin Masa Hesabını kapatıyoruz
        public bool billClose(cOdeme bill)
        {
            bool result=false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into hesapOdemeleri(ADISYONID,ODEMETURID,MUSTERIID,ARATOPLAM,KDVTUTARI,TOPLAMTUTAR,INDIRIM) values(@ADISYONID,@ODEMETURID,@MUSTERIID,@ARATOPLAM,@KDVTUTARI,@TOPLAMTUTAR,@INDIRIM)",con);

            try
            {
                if(con.State==System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONID", System.Data.SqlDbType.Int).Value = bill._AdisyonID;
                cmd.Parameters.Add("@ODEMETURID", System.Data.SqlDbType.Int).Value = bill._OdemeTurId;
                cmd.Parameters.Add("@MUSTERIID", System.Data.SqlDbType.Int).Value = bill._MusteriId;
                cmd.Parameters.Add("@ARATOPLAM", System.Data.SqlDbType.Money).Value = bill._AraToplam;
                cmd.Parameters.Add("@KDVTUTARI", System.Data.SqlDbType.Money).Value = bill._Kdvtutari;
                cmd.Parameters.Add("@TOPLAMTUTAR", System.Data.SqlDbType.Money).Value = bill._GenelToplam;
                cmd.Parameters.Add("@INDIRIM", System.Data.SqlDbType.Int).Value = bill._Indirim;

                result =Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
    }
}
