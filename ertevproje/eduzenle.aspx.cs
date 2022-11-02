using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class eduzenle : System.Web.UI.Page
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
            EgitimCRUD oislem = new EgitimCRUD();
            if (Request.QueryString["prm"] == null)
            {
                DataTable tablom = new DataTable();

                tablom = oislem.liste();
                tblist.InnerHtml = "<table border='1' class='table table-warning' >";
                tblist.InnerHtml += "<tr><td>Eğitim No</td><td>Eğitim Ad</td><td>Süre</td><td>Kontenjan</td><td>Başlangıç Tarihi</td><td>Bitiş Tarihi</td><td>İçerik</td><td>Sil</td><td>Güncelle</td></tr>";
                for (int i = 0; i < tablom.Rows.Count; i++)
                {
                    tblist.InnerHtml += "<tr><td>" + tablom.Rows[i][0] + "</td><td>" + tablom.Rows[i][1] + "</td><td>" + tablom.Rows[i][2] + "</td><td>" + tablom.Rows[i][3] + "</td><td>" + tarih(Convert.ToString(tablom.Rows[i][4])) + "</td><td>" + tarih(Convert.ToString(tablom.Rows[i][5])) + "</td><td>" + tablom.Rows[i][6] + "</td><td><a href='eduzenle.aspx?prm=" + tablom.Rows[i][0] + "'onclick=\"return confirm('Kaydı silmek istediğinizden emin misiniz?');\"><img src='img/person-x.svg' width='50px' height='50px'></a></td><td><a href='eguncelle.aspx?prm=" + tablom.Rows[i][0] + "'><img src='img/pencil-square.svg' width='50px' height='50px'></a></td></tr>";
                }
                tblist.InnerHtml += "</table>";
            }
            else
            {
                gelen = oislem.sil(Convert.ToInt32(Request.QueryString["prm"]));
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

                tablom = oislem.liste();
                tblist.InnerHtml = "<table border='1' class='table table-warning table-md-6 table-lg-12'>";
                tblist.InnerHtml += "<tr><td>Eğitim No</td><td>Eğitim Ad</td><td>Süre</td><td>Kontenjan</td><td>Başlangıç Tarihi</td><td>Bitiş Tarihi</td><td>İçerik</td><td>Sil</td><td>Güncelle</td></tr>";
                for (int i = 0; i < tablom.Rows.Count; i++)
                {
                    tblist.InnerHtml += "<tr><td>" + tablom.Rows[i][0] + "</td><td>" + tablom.Rows[i][1] + "</td><td>" + tablom.Rows[i][2] + "</td><td>" + tablom.Rows[i][3] + "</td><td>" + tarih(Convert.ToString(tablom.Rows[i][4])) + "</td><td>" + tarih(Convert.ToString(tablom.Rows[i][5])) + "</td><td>" + tablom.Rows[i][6] + "</td><td><a href='eduzenle.aspx?prm=" + tablom.Rows[i][0] + "'onclick=\"return confirm('Kaydı silmek istediğinizden emin misiniz?');\"><img src='img/person-x.svg' width='50px' height='50px'></a></td><td><a href='eguncelle.aspx?prm=" + tablom.Rows[i][0] + "'><img src='img/pencil-square.svg' width='50px' height='50px'></a></td></tr>";
                }
                tblist.InnerHtml += "</table>";
            }
        }
    }
}