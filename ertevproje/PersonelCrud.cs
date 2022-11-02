using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ertevproje
{
    public class PersonelCrud
    {
        Db db = new Db();
        public string kaydet(Personel nper)
        {
            int ksay;
            string cevap = "Kayıt Başarılı!";
            db.ac();
            SqlCommand komut = new SqlCommand("insert into personel values(@ad,@soyad,@cinsiyet,@dtar,@d_yeri,@tel,@email,@adres,@is_giris_tar,@maas,@foto,@birim)", db.baglanti);
            komut.Parameters.AddWithValue("@ad", nper.Ad);
            komut.Parameters.AddWithValue("@soyad", nper.Soyad);
            komut.Parameters.AddWithValue("@cinsiyet", nper.Cins);
            komut.Parameters.AddWithValue("@dtar", nper.Dtar);
            komut.Parameters.AddWithValue("@d_yeri", nper.Dyeri);
            komut.Parameters.AddWithValue("@tel", nper.Tel);
            komut.Parameters.AddWithValue("@email", nper.Email);
            komut.Parameters.AddWithValue("@adres", nper.Adres);
            komut.Parameters.AddWithValue("@is_giris_tar", nper.Isgisristar);
            komut.Parameters.AddWithValue("@maas", nper.Maas);
            komut.Parameters.AddWithValue("@foto", nper.Foto);
            komut.Parameters.AddWithValue("@birim", nper.Birim);
            ksay = komut.ExecuteNonQuery();
            if (ksay == 0)
            {
                cevap = "Hata! Kayıt Yapılamadı.";
            }

            db.kapa();
            return cevap;
        }

        public DataTable ekip()
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            db.ac();
            SqlCommand komut = new SqlCommand("select ad,soyad,email,birim,foto from personel", db.baglanti);
            adp.SelectCommand = komut;
            adp.Fill(tbl);

            db.kapa();
            return tbl;
        }
        public DataTable liste()
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            db.ac();
            SqlCommand komut = new SqlCommand("select per_no,ad,soyad,cinsiyet,dtar,il,tel,email,adres,is_giris_tar, CONVERT(VARCHAR(30), CONVERT(DECIMAL(15,2), [maas]))+'TL' from personel,sehir where sehir.plaka=personel.d_yeri", db.baglanti);
            adp.SelectCommand = komut;
            adp.Fill(tbl);

            db.kapa();
            return tbl;
        }
        public bool sil(int pno)
        {
            bool cevap = true;
            int ksay;
            db.ac();
            SqlCommand komut = new SqlCommand("delete from personel where per_no=@id", db.baglanti);
            komut.Parameters.AddWithValue("@id", pno);
            ksay = komut.ExecuteNonQuery();
            if (ksay == 0)
            {
                cevap = false;
            }
            db.kapa();
            return cevap;
        }
        public Personel getper(int perno)
        {
            Personel gp = new Personel();
            db.ac();
            DataTable dt = new DataTable();
            SqlCommand komut = new SqlCommand("select * from personel where per_no=@perno", db.baglanti);
            komut.Parameters.AddWithValue("@perno", perno);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            adp.Fill(dt);
            gp.Perno = Convert.ToInt32(dt.Rows[0][0]);
            gp.Ad = Convert.ToString(dt.Rows[0][1]);
            gp.Soyad = Convert.ToString(dt.Rows[0][2]);
            gp.Cins = Convert.ToString(dt.Rows[0][3]);
            gp.Dtar = Convert.ToDateTime(dt.Rows[0][4]);
            gp.Tel = Convert.ToString(dt.Rows[0][6]);
            gp.Email = Convert.ToString(dt.Rows[0][7]);
            gp.Adres = Convert.ToString(dt.Rows[0][8]);
            gp.Isgisristar = Convert.ToDateTime(dt.Rows[0][9]);
            gp.Maas = Convert.ToInt32(dt.Rows[0][10]);
           

            return gp;
        }
        public bool guncelle(Personel uper)
        {
            int ksay;
            bool cevap = true;
            //veritabanına bağlantı yolu açılır.
            db.ac();
            SqlCommand komut = new SqlCommand("update personel set ad=@ad,soyad=@soyad,cinsiyet=@cinsiyet,dtar=@dtar,d_yeri=@dyeri,tel=@tel,email=@email,adres=@adres,is_giris_tar=@isgiristar,maas=@maas where per_no=@perno", db.baglanti);
            komut.Parameters.AddWithValue("@perno", uper.Perno);
            komut.Parameters.AddWithValue("@ad",uper.Ad);
            komut.Parameters.AddWithValue("@soyad",uper.Soyad);
            komut.Parameters.AddWithValue("@cinsiyet", uper.Cins);
            komut.Parameters.AddWithValue("@dtar", uper.Dtar);
            komut.Parameters.AddWithValue("@dyeri", uper.Dyeri);
            komut.Parameters.AddWithValue("@tel", uper.Tel);
            komut.Parameters.AddWithValue("@email", uper.Email);
            komut.Parameters.AddWithValue("@adres", uper.Adres);
            komut.Parameters.AddWithValue("@isgiristar", uper.Isgisristar);
            komut.Parameters.AddWithValue("@maas", uper.Maas);
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
