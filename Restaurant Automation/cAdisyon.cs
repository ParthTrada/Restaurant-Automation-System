using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Restaurant_Otomasyonu
{
    class cAdisyon
    {
        cGenel gnl=new cGenel();

        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId;

        public int ID { get => _ID; set => _ID = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        public int getByAddition(int MasaId)
        {
            SqlConnection con=new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID from adisyonlar Where MASAID=@MasaId Order by ID desc",con);
            cmd.Parameters.Add("@MasaId",System.Data.SqlDbType.Int).Value=MasaId;
            try 
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return MasaId;
        }
        public bool setByAdditionNew(cAdisyon bilgiler)
        {
            bool sonuc = false;
            SqlConnection con=new SqlConnection (gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into adisyonlar(SERVISTURNO,TARIH,PERSONELID,MASAID,DURUM) values(@ServisTurno,@Tarih,@PersonelID,@MasaId,@Durum)",con);
            try
            {
                if (con.State ==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = bilgiler.ServisTurNo;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = bilgiler.Tarih;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaId",SqlDbType.Int).Value=bilgiler.MasaId;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 0;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
            }
            finally {
                con.Dispose();
                con.Close(); 

            }
            return sonuc;
        }
        public void adisyonkapat(int adisyonID,int durum)
        {
          
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update adisyonlar set durum=@durum where ID=@adisyonId", con);

            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", System.Data.SqlDbType.Int).Value = adisyonID;
                cmd.Parameters.Add("@durum", System.Data.SqlDbType.Int).Value = durum;
                cmd.ExecuteNonQuery();
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
    }
}
