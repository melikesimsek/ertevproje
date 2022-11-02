using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ertevproje
{
    public class UserCRUD
    {
            Db db = new Db();
            public string kaydet(User nuser)
            {
                int ksay;
                string cevap = "Kayıt Başarılı!";
                db.ac();
                SqlCommand komut = new SqlCommand("insert into kullanici values(@id,@kul_adi,@sifre)", db.baglanti);
                komut.Parameters.AddWithValue("@id", nuser.Id);
                komut.Parameters.AddWithValue("@kul_adi", nuser.Kul_adi);
                komut.Parameters.AddWithValue("@sifre", nuser.Sifre);
                ksay = komut.ExecuteNonQuery();
                if (ksay == 0)
                {
                    cevap = "Hata! Kayıt Yapılamadı.";
                }

                db.kapa();
                return cevap;
            }
        public DataTable liste()
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            db.ac();
            SqlCommand komut = new SqlCommand("select * from kullanici", db.baglanti);
            adp.SelectCommand = komut;
            adp.Fill(tbl);

            db.kapa();
            return tbl;
        }
        public bool sil(int uno)
        {
            bool cevap = true;
            int ksay;
            db.ac();
            SqlCommand komut = new SqlCommand("delete from kullanici where id=@id", db.baglanti);
            komut.Parameters.AddWithValue("@id", uno);
            ksay = komut.ExecuteNonQuery();
            if (ksay == 0)
            {
                cevap = false;
            }
            db.kapa();
            return cevap;
        }
        public User getuser(int uno)
        {
            User gu = new User();
            db.ac();
            DataTable dt = new DataTable();
            SqlCommand komut = new SqlCommand("select * from kullanici where id=@uno", db.baglanti);
            komut.Parameters.AddWithValue("@uno", uno);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            adp.Fill(dt);
            gu.Id = Convert.ToInt32(dt.Rows[0][0]);
            gu.Kul_adi = Convert.ToString(dt.Rows[0][1]);
            gu.Sifre = Convert.ToString(dt.Rows[0][2]);
        
            return gu;
        }
        public bool guncelle(User uuser)
        {
            int ksay;
            bool cevap = true;
            //veritabanına bağlantı yolu açılır.
            db.ac();
            SqlCommand komut = new SqlCommand("update kullanici set id=@id, kul_adi=@kul_adi, sifre=@sifre where id=@id", db.baglanti);
            komut.Parameters.AddWithValue("@id", uuser.Id);
            komut.Parameters.AddWithValue("@kul_adi", uuser.Kul_adi);
            komut.Parameters.AddWithValue("@sifre", uuser.Sifre);
            ksay = komut.ExecuteNonQuery();
            if (ksay == 0)
            {
                cevap = false;
            }

            db.kapa();
            return cevap;
        }

    }
}