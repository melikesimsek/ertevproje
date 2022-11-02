using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ertevproje
{
    public class EgitimCRUD
    {
        Db db = new Db();
        public string kaydet(Egitim negt)
        {
            int ksay;
            string cevap = "Kayıt Başarılı!";
            db.ac();
            SqlCommand komut = new SqlCommand("insert into kurslar values(@no,@ad,@sure,@kont,@bastar,@bittar,@icerik)", db.baglanti);
            komut.Parameters.AddWithValue("@no", negt.Kurs_no);
            komut.Parameters.AddWithValue("@ad", negt.Kursadi);
            komut.Parameters.AddWithValue("@sure", negt.Sure);
            komut.Parameters.AddWithValue("@kont", negt.Kontenjan);
            komut.Parameters.AddWithValue("@bastar", negt.Bas_tar);
            komut.Parameters.AddWithValue("@bittar", negt.Bit_tar);
            komut.Parameters.AddWithValue("@icerik", negt.Icerik);
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
            SqlCommand komut = new SqlCommand("select * from kurslar", db.baglanti);
            adp.SelectCommand = komut;
            adp.Fill(tbl);

            db.kapa();
            return tbl;
        }
        public bool sil(int eno)
        {
            bool cevap = true;
            int ksay;
            db.ac();
            SqlCommand komut = new SqlCommand("delete from kurslar where kurs_no=@id", db.baglanti);
            komut.Parameters.AddWithValue("@id", eno);
            ksay = komut.ExecuteNonQuery();
            if (ksay == 0)
            {
                cevap = false;
            }
            db.kapa();
            return cevap;
        }
        public Egitim getegt(int eno)
        {
            Egitim egno = new Egitim();
            db.ac();
            DataTable dt = new DataTable();
            SqlCommand komut = new SqlCommand("select * from kurslar where kurs_no=@kursno", db.baglanti);
            komut.Parameters.AddWithValue("@kursno", eno);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            adp.Fill(dt);
            egno.Kurs_no = Convert.ToInt32(dt.Rows[0][0]);
            egno.Kursadi = Convert.ToString(dt.Rows[0][1]);
            egno.Sure = Convert.ToString(dt.Rows[0][2]);
            egno.Kontenjan = Convert.ToString(dt.Rows[0][3]);
            egno.Bas_tar = Convert.ToDateTime(dt.Rows[0][4]);
            egno.Bit_tar = Convert.ToDateTime(dt.Rows[0][5]);
            egno.Icerik = Convert.ToString(dt.Rows[0][6]);

            return egno;
        }
        public bool guncelle(Egitim uegt)
        {
            int ksay;
            bool cevap = true;
            //veritabanına bağlantı yolu açılır.
            db.ac();
            SqlCommand komut = new SqlCommand("update kurslar set kurs_adi=@ad,sure=@sure,kontenjan=@kont,bas_tar=@bastar,bitis_tar=@bittar,icerik=@icerik where kurs_no=@no", db.baglanti);
            komut.Parameters.AddWithValue("@no", uegt.Kurs_no);
            komut.Parameters.AddWithValue("@ad", uegt.Kursadi);
            komut.Parameters.AddWithValue("@sure", uegt.Sure);
            komut.Parameters.AddWithValue("@kont", uegt.Kontenjan);
            komut.Parameters.AddWithValue("@bastar", uegt.Bas_tar);
            komut.Parameters.AddWithValue("@bittar", uegt.Bit_tar);
            komut.Parameters.AddWithValue("@icerik", uegt.Icerik);

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
