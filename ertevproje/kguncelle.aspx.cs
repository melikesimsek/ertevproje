using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class kguncelle : System.Web.UI.Page
    {
        UserCRUD uislem = new UserCRUD();
        User gu = new User();

        protected void Page_Load(object sender, EventArgs e)
        {
            int uno = Convert.ToInt32(Request.QueryString["prm"]);
            if (!IsPostBack)//kayıt ilk yüklenişte hata versin
            {
                gu = uislem.getuser(uno);
                TextBox1.Text = gu.Id.ToString();
                TextBox2.Text = gu.Kul_adi.ToString();
                TextBox3.Text = gu.Sifre.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            gu.Id = Convert.ToInt32(TextBox1.Text);
            gu.Kul_adi = TextBox2.Text;
            gu.Sifre = TextBox3.Text;

            if (uislem.guncelle(gu))
            {
                Response.Redirect("kduzenle.aspx");
                bilgi.InnerHtml = "Güncelleme Başarılı";
            }
            else bilgi.InnerHtml = "Güncellenemedi.";
        }
    }
}