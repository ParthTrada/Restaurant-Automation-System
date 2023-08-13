using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Otomasyonu
{
    class cSiparis
    {
        cGenel gnl=new cGenel();

        private int _Id;
        private int _adisyonID;
        private int _urunId;
        private int _adet;
        private int _masaId;

        public int Id { get => _Id; set => _Id = value; }
        public int AdisyonID { get => _adisyonID; set => _adisyonID = value; }
        public int UrunId { get => _urunId; set => _urunId = value; }
        public int Adet { get => _adet; set => _adet = value; }
        public int MasaId { get => _masaId; set => _masaId = value; }
        public void getByOrder(ListView lv,int AdisyonId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select URUNAD,FİYAT,satislar.ID,URUNID,satislar.ADET FROM satislar inner join urunler on satislar.URUNID=urunler.ID where satislar.ADISYONID=@AdisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId",System.Data.SqlDbType.Int).Value=AdisyonId;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FİYAT"]) * Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());
                    sayac++;
                }

            }
            catch (SqlException ex){
                string hata = ex.Message;
            }
            finally {
                
                con.Dispose();
                con.Close();
                dr.Close();
            }
        }
        public bool setSaveOrder(cSiparis bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into satislar (ADISYONID,URUNID,ADET,MASAID) values(@AdisyonNo,@UrunId,@Adet,@masaId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdisyonNo", SqlDbType.Int).Value = bilgiler._adisyonID;
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = bilgiler._urunId;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = bilgiler._adet;
                cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = bilgiler._masaId;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();

            }
            return sonuc;
        }
        public void setDeleteOrder(int satisId)
        {
            SqlConnection con=new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete From Satislar Where ID=@SatisID", con);
            cmd.Parameters.Add("@SatisID",SqlDbType.Int).Value = satisId;
            if(con.State== ConnectionState.Closed)
            {
                con.Open() ;
            }
            cmd.ExecuteNonQuery();
            con.Dispose() ;
            con.Close();
        }
        public void setCancelOrder(int masaId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);

            SqlCommand cmd = new SqlCommand("Delete From Satislar Where MASAID=@masaid", con);
            cmd.Parameters.Add("@masaid", SqlDbType.Int).Value = masaId;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }

    }
    
}
