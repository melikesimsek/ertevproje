using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ertevproje
{
    public class Egitim
    {
        int kurs_no;
        DateTime bas_tar, bit_tar;
        string kursadi, sure, kontenjan, icerik;

        public int Kurs_no { get => kurs_no; set => kurs_no = value; }
        public DateTime Bas_tar { get => bas_tar; set => bas_tar = value; }
        public DateTime Bit_tar { get => bit_tar; set => bit_tar = value; }
        public string Kursadi { get => kursadi; set => kursadi = value; }
        public string Sure { get => sure; set => sure = value; }
        public string Kontenjan { get => kontenjan; set => kontenjan = value; }
        public string Icerik { get => icerik; set => icerik = value; }
    }
}