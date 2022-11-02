using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class kduzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                bool gelen;
                UserCRUD eislem = new UserCRUD();
                if (Request.QueryString["prm"] == null)
                {
                    DataTable tablom = new DataTable();

                    tablom = eislem.liste();
                    tblist.InnerHtml = "<table border='1' class='table table-warning'>";
                    tblist.InnerHtml += "<tr><td>Kullanıcı ID</td><td>Kullancı Ad</td>><td>Şifre</td><td>Sil</td><td>Güncelle</td></tr>";
                    for (int i = 0; i < tablom.Rows.Count; i++)
                    {
                        tblist.InnerHtml += "<tr><td>" + tablom.Rows[i][0] + "</td><td>" + tablom.Rows[i][1] + "</td><td>" + tablom.Rows[i][2] + "</td><td><a href='kduzenle.aspx?prm=" + tablom.Rows[i][0] + "''onclick=\"return confirm('Kaydı silmek istediğinizden emin misiniz?');\"><img src='img/person-x.svg' width='50px' height='50px'></a></td><td><a href='kguncelle.aspx?prm=" + tablom.Rows[i][0] + "'><img src='img/pencil-square.svg' width='50px' height='50px'></a></td></tr>";
                    }
                    tblist.InnerHtml += "</table>";
                }
                else
                {
                    gelen = eislem.sil(Convert.ToInt32(Request.QueryString["prm"]));
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

                    tablom = eislem.liste();
                    tblist.InnerHtml = "<table border='1' class='table table-warning font-weight-bold'>";
                    tblist.InnerHtml += "<tr><td>Kullanıcı ID</td><td>Kullancı Ad</td>><td>Şifre</td><td>Sil</td><td>Güncelle</td></tr>";
                    for (int i = 0; i < tablom.Rows.Count; i++)
                    {
                        tblist.InnerHtml += "<tr><td>" + tablom.Rows[i][0] + "</td><td>" + tablom.Rows[i][1] + "</td><td>" + tablom.Rows[i][2] + "</td><td><a href='kduzenle.aspx?prm=" + tablom.Rows[i][0] + "'onclick=\"return confirm('Kaydı silmek istediğinizden emin misiniz?');\"><img src='img/person-x.svg' width='50px' height='50px'></a></td><td><a href='kguncelle.aspx?prm=" + tablom.Rows[i][0] + "'><img src='img/pencil-square.svg' width='50px' height='50px'></a></td></tr>";
                    }
                    tblist.InnerHtml += "</table>";
            
            }
        }
    }
}