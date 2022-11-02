using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class ekip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonelCrud pislem = new PersonelCrud();
            if (Request.QueryString["prm"] == null)
            {
                DataTable tablom = new DataTable();

                tablom = pislem.ekip();
                perlist.InnerHtml = "<table border='1' class='table table-warning'>";
                perlist.InnerHtml += "<tr><td>Fotoğraf</td><td>Ad</td><td>Soyad</td><td>Email</td><td>Çalıştığı Birim</td>";
                for (int i = 0; i < tablom.Rows.Count; i++)
                {
                    perlist.InnerHtml += "<tr><td><img src='img/avatar.jpg' width='70px' height='70px'></td><td>" + tablom.Rows[i][0] + "</td><td>" + tablom.Rows[i][1] + "</td><td>" + tablom.Rows[i][2] + "</td><td>" + tablom.Rows[i][4] + "</td><td> ";
                }
                perlist.InnerHtml += "</table>";
            }
        }
    }
}