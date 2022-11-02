using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ertevproje
{
    public class OgrenciCRUD
    {
        Db db = new Db();
        public string kaydet(Ogrenci nogr)
        {
            int ksay;
            string cevap = "Kayıt Başarılı!";
            db.ac();
            SqlCommand komut = new SqlCommand("insert into ogrenciler values(@ad,@soyad,@cinsiyet,@dtar,@d_yeri,@tel,@email,@adres,@kursno)", db.baglanti);
            komut.Parameters.AddWithValue("@ad", nogr.Ad);
            komut.Parameters.AddWithValue("@soyad", nogr.Soyad);
            komut.Parameters.AddWithValue("@cinsiyet", nogr.Cinsiyet);
            komut.Parameters.AddWithValue("@dtar", nogr.D_tar);
            komut.Parameters.AddWithValue("@d_yeri", nogr.Dyeri);
            komut.Parameters.AddWithValue("@tel", nogr.Tel);
            komut.Parameters.AddWithValue("@email", nogr.Email);
            komut.Parameters.AddWithValue("@adres", nogr.Adres);
            komut.Parameters.AddWithValue("@kursno", nogr.Kursno);
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
            SqlCommand komut = new SqlCommand("select ogr_no,ad,soyad,cinsiyet,d_tar,il,tel,email,adres,kurs_adi from ogrenciler,kurslar,sehir where sehir.plaka=ogrenciler.dyeri and kurslar.kurs_no=ogrenciler.kurs_no", db.baglanti);
            adp.SelectCommand = komut;
            adp.Fill(tbl);

            db.kapa();
            return tbl;
        }
        public bool sil(int ono)
        {
            bool cevap = true;
            int ksay;
            db.ac();
            SqlCommand komut = new SqlCommand("delete from ogrenciler where ogr_no=@id", db.baglanti);
            komut.Parameters.AddWithValue("@id", ono);
            ksay = komut.ExecuteNonQuery();
            if (ksay == 0)
            {
                cevap = false;
            }
            db.kapa();
            return cevap;
        }
        public Ogrenci getogr(int ogrno)
        {
            Ogrenci go = new Ogrenci();
            db.ac();
            DataTable dt = new DataTable();
            SqlCommand komut = new SqlCommand("select * from ogrenciler where ogr_no=@ogrno", db.baglanti);
            komut.Parameters.AddWithValue("@ogrno", ogrno);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            adp.Fill(dt);
            go.Ogr_no = Convert.ToInt32(dt.Rows[0][0]);
            go.Ad = Convert.ToString(dt.Rows[0][1]);
            go.Soyad = Convert.ToString(dt.Rows[0][2]);
            go.Cinsiyet = Convert.ToString(dt.Rows[0][3]);
            go.D_tar = Convert.ToDateTime(dt.Rows[0][4]);
            go.Dyeri = Convert.ToString(dt.Rows[0][5]);
            go.Tel = Convert.ToString(dt.Rows[0][6]);
            go.Email = Convert.ToString(dt.Rows[0][7]);
            go.Adres = Convert.ToString(dt.Rows[0][8]);

            return go;
        }
        public bool guncelle(Ogrenci uogr)
        {
            int ksay;
            bool cevap = true;
            //veritabanına bağlantı yolu açılır.
            db.ac();
            SqlCommand komut = new SqlCommand("update ogrenciler set ad=@ad,soyad=@soyad,cinsiyet=@cinsiyet,d_tar=@dtar,dyeri=@dyeri,tel=@tel,email=@email,adres=@adres, kurs_no=@kursno where ogr_no=@ogrno", db.baglanti);
            komut.Parameters.AddWithValue("@ogrno", uogr.Ogr_no);
            komut.Parameters.AddWithValue("@ad", uogr.Ad);
            komut.Parameters.AddWithValue("@soyad", uogr.Soyad);
            komut.Parameters.AddWithValue("@cinsiyet", uogr.Cinsiyet);
            komut.Parameters.AddWithValue("@dtar", uogr.D_tar);
            komut.Parameters.AddWithValue("@dyeri", uogr.Dyeri);
            komut.Parameters.AddWithValue("@tel", uogr.Tel);
            komut.Parameters.AddWithValue("@email", uogr.Email);
            komut.Parameters.AddWithValue("@adres", uogr.Adres);
            komut.Parameters.AddWithValue("@kursno", uogr.Kursno);
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
