using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ertevproje
{
    public class Ogrenci
    {
        int ogr_no,kursno;
        string ad, soyad, cinsiyet, dyeri, tel, email, adres;
        DateTime d_tar;

        public int Ogr_no { get => ogr_no; set => ogr_no = value; }
        public int Kursno { get => kursno; set => kursno = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
      
        public string Dyeri { get => dyeri; set => dyeri = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Adres { get => adres; set => adres = value; }
        public DateTime D_tar { get => d_tar; set => d_tar = value; }
    }
}