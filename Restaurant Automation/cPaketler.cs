using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Otomasyonu
{
    class cPaketler
    {
        cGenel gnl = new cGenel();
        private int _ID;
        private int _AdditionID;
        private int _ClientId;
        private string _Description;
        private int _State;
        private int __Paytypeid;

        public int ID { get => _ID; set => _ID = value; }
        public int AdditionID { get => _AdditionID; set => _AdditionID = value; }
        public int ClientId { get => _ClientId; set => _ClientId = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int State { get => _State; set => _State = value; }
        public int _Paytypeid { get => __Paytypeid; set => __Paytypeid = value; }
        //Paket Servisi Açma
        public bool OrderServiceOpen(cPaketler order)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into paketSiparis(ADISYONID,MUSTERIID,ODEMETURID,ACIKLAMA) values(@ADISYONID,@MUSTERIID,@ODEMETURID,@ACIKLAMA)", con);
            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONID",SqlDbType.Int).Value=order._AdditionID;
                cmd.Parameters.Add("@MUSTERIID",SqlDbType.Int).Value= order._ClientId;
                cmd.Parameters.Add("@ODEMETURID", SqlDbType.Int).Value = order.__Paytypeid;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = order._Description;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }catch (SqlException ex)
            {
                string hata=ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        //Paket Servisi Kapatma
        public void OrderServiceClose(int AdditionID)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update paketSiparis set paketSiparis.durum=1 from paketSiparis Inner Join adisyonlar on paketSiparis.ADISYONID=adisyonlar.ID where paketSiparis.ADISYONID=@AdditionID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdditionID", SqlDbType.Int).Value = AdditionID;
              
                Convert.ToBoolean(cmd.ExecuteNonQuery());
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
            
        }
        //açılan adisyon ve paket sipariş ait ön girilen odeme tur id
        public int OdemeTurIdGetir(int adisyonId) {
            int odemeTurID = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select paketSiparis.ODEMETURID from paketSiparis Inner Join adisyonlar on paketSiparis.ADISYONID=adisyonlar.ID where adisyonlar.ID=@adisyonId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value =adisyonId;
  
               odemeTurID=Convert.ToInt32(cmd.ExecuteScalar());
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
            return odemeTurID;
        }
        //Sipariş kontrol için müşteriye ait açık olan en son adisyon nosunu getirme
        //bir müşteriye ait 2 tane siparişin açık olmayacağını belirtiyoruz.
    }
}
