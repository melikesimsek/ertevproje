using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ertevproje
{
    public class User
    {
        int id;
        string kul_adi, sifre;

        public int Id { get => id; set => id = value; }
        public string Kul_adi { get => kul_adi; set => kul_adi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}