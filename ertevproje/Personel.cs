using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ertevproje
{
    public class Personel
    {
        int perno, maas;
        DateTime dtar, isgisristar;
        string ad, soyad,cins, dyeri, tel, email, adres,foto,birim;

        public int Perno { get => perno; set => perno = value; }
        public int Maas { get => maas; set => maas = value; }
        public DateTime Dtar { get => dtar; set => dtar = value; }
        public DateTime Isgisristar { get => isgisristar; set => isgisristar = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Dyeri { get => dyeri; set => dyeri = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Cins { get => cins; set => cins = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Birim { get => birim; set => birim = value; }
    }
}