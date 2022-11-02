using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class pduzenle : System.Web.UI.Page
    {
        public string tarih(string tar)
        {
            string cevap;
            cevap = Convert.ToDateTime(tar).ToShortDateString();
            return cevap;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            bool gelen;
            PersonelCrud pislem = new PersonelCrud();
            if (Request.QueryString["prm"] == null)
            {
                DataTable tablom = new DataTable();

                tablom = pislem.liste();
                tblist.InnerHtml = "<table border='1' class='table table-warning'>";
                tblist.InnerHtml += "<tr><td>Personel No</td><td>Ad</td><td>Soyad</td><td>Cinsiyet</td><td>Doğum Tarihi</td><td>Doğum Yeri</td><td>Telefon</td><td>Email</td><td>Adres</td><td>İşe Giriş Tarihi</td><td>Maaş</td><td>Sil</td><td>Güncelle</td></tr>";
                for (int i = 0; i < tablom.Rows.Count; i++)
                {
                    tblist.InnerHtml += "<tr><td>" + tablom.Rows[i][0] + "</td><td>" + tablom.Rows[i][1] + "</td><td>" + tablom.Rows[i][2] + "</td><td>" + tablom.Rows[i][3] + "</td><td>"+ tarih(Convert.ToString(tablom.Rows[i][4])) + "</td><td>" + tablom.Rows[i][5] + "</td><td>" + tablom.Rows[i][6] + "</td><td>" + tablom.Rows[i][7] + "</td><td>" + tablom.Rows[i][8] + "</td><td> " + tarih(Convert.ToString(tablom.Rows[i][9]))+ "</td><td>" + tablom.Rows[i][10] + "</td><td><a href='pduzenle.aspx?prm=" + tablom.Rows[i][0] + "'onclick=\"return confirm('Kaydı silmek istediğinizden emin misiniz?');\"><img src='img/person-x.svg' width='50px' height='50px'></a></td><td><a href='pguncelle.aspx?prm=" + tablom.Rows[i][0] + "'><img src='img/pencil-square.svg' width='50px' height='50px'></a></td></tr>";
                }
                tblist.InnerHtml += "</table>";
            }
            else
            {
                gelen = pislem.sil(Convert.ToInt32(Request.QueryString["prm"]));
                if (gelen == true)
                {
                    System.Web.UI.HtmlControls.HtmlGenericControl tabloliste1 = tblist;
                    bilgi.InnerHtml = ("Kaydınız Silindi");

                }
                else
                {
                    bilgi.InnerHtml = ("Kaydınız Silinemedi");
                }
                DataTable tablom = new DataTable();

                tablom = pislem.liste();
                tblist.InnerHtml = "<table border='1'>";
                tblist.InnerHtml += "<tr><td>Personel No</td><td>Ad</td><td>Soyad</td><td>Cinsiyet</td><td>Doğum Tarihi</td><td>Doğum Yeri</td><td>Telefon</td><td>Email</td><td>Adres</td><td>İşe Giriş Tarihi</td><td>Maaş</td><td>Sil</td><td>Güncelle</td></tr>";
                for (int i = 0; i < tablom.Rows.Count; i++)
                {
                    tblist.InnerHtml += "<tr><td>" + tablom.Rows[i][0] + "</td><td>" + tablom.Rows[i][1] + "</td><td>" + tablom.Rows[i][2] + "</td><td>" + tablom.Rows[i][3] + "</td><td>" + tarih(Convert.ToString(tablom.Rows[i][4])) + "</td><td>" + tablom.Rows[i][5] + "</td><td>" + tablom.Rows[i][6] + "</td><td>" + tablom.Rows[i][7] + "</td><td>" + tablom.Rows[i][8] + "</td><td> " + tarih(Convert.ToString(tablom.Rows[i][9])) + "</td><td>" + tablom.Rows[i][10] + "</td><td><a href='pduzenle.aspx?prm=" + tablom.Rows[i][0] + "'onclick=\"return confirm('Kaydı silmek istediğinizden emin misiniz?');\"><img src='img/person-x.svg' width='50px' height='50px'></a></td><td><a href='pguncelle.aspx?prm=" + tablom.Rows[i][0] + "'><img src='img/pencil-square.svg' width='50px' height='50px'></a></td></tr>";
                }
                tblist.InnerHtml += "</table>";
            }
        }
    }
}