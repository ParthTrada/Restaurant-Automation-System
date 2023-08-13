using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Restaurant_Otomasyonu
{
    class cMasalar
    {
        private int _ID;
        private int _KAPASITE;
        private int _SERVISTURU;
        private int _DURUM;
        private int _ONAY;
        private string _MasaBilgi;

        cGenel gnl =new cGenel();

        public int ID { get => _ID; set => _ID = value; }
        public int KAPASITE { get => _KAPASITE; set => _KAPASITE = value; }
        public int SERVISTURU { get => _SERVISTURU; set => _SERVISTURU = value; }
        public int DURUM { get => _DURUM; set => _DURUM = value; }
        public int ONAY { get => _ONAY; set => _ONAY = value; }
        public string MasaBilgi { get => _MasaBilgi; set => _MasaBilgi = value; }

        public string SessionSum(int state)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select TARIH,MASAID from adisyonlar Right Join Masalar on adisyonlar.MASAID=Masalar.ID Where Masalar.DURUM=@durum and adisyonlar.DURUM=0",con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum",System.Data.SqlDbType.Int).Value=state;
            try
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["TARIH"]).ToString();
                }
            }
            catch(SqlException ex)
            {
                string hata=ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            
            return dt;
        }
        public int TableGetbyNumber(string TableValue)
        {
            string aa = TableValue;
            int lenght = aa.Length;
            if (lenght > 8)
            {
                return Convert.ToInt32(aa.Substring(lenght - 2,2));
            }
            else
            {
                return Convert.ToInt32(aa.Substring(lenght - 1,1));
            }
            
        }
        public bool TableGetbyState(int ButtonName,int state)
        {
            bool result = false;
            SqlConnection con=new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select durum From masalar Where ID=@TableId and DURUM=@state",con);
            cmd.Parameters.Add("@TableId",SqlDbType.Int).Value=ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                string hata=ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        public void setChangeTableState(string ButonName,int state)
        {
            SqlConnection con=new SqlConnection (gnl.conString);
            string masaNo = "";
            SqlCommand cmd = new SqlCommand("Update masalar set DURUM=@Durum where ID=@MasaNo", con);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = ButonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            if(uzunluk > 0)
            {
                masaNo=aa.Substring(uzunluk-2,2);
            }
            else 
            { 
                masaNo=aa.Substring(uzunluk-1,1);
            }
            
            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
    }
}
