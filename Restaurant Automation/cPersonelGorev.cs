using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Otomasyonu
{
     class cPersonelGorev
    {
        cGenel gnl=new cGenel();
        private int _personelGorevId;
        private string _tanim;

        public int PersonelGorevId { get => _personelGorevId; set => _personelGorevId = value; }
        public string Tanim { get => _tanim; set => _tanim = value; }
        public void PersonelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con=new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from personelGorev", con);
            SqlDataReader dr = null;
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                dr= cmd.ExecuteReader();
                while (dr.Read())
                {
                    cPersonelGorev c = new cPersonelGorev();
                    c._personelGorevId = Convert.ToInt32(dr["ID"].ToString());
                    c._tanim = dr["GOREV"].ToString();
                    cb.Items.Add(c);
                }
            }
            catch (SqlException ex)
            {
                string hata=ex.Message;
                throw;
            }
            dr.Close();
            con.Close();
        }
        public string PersonelGorevTanim(int per)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select GOREV from personelGorev where ID=@perId", con);
            cmd.Parameters.Add("@perId",System.Data.SqlDbType.Int).Value=per;
           
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            
            con.Close();
            return sonuc;
        }
        public override string ToString()
        {
            return _tanim;
        }
    }
}
