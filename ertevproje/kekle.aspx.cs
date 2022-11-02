using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class kekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User yu = new User();
            yu.Id = Convert.ToInt32(TextBox1.Text);
            yu.Kul_adi = TextBox2.Text;
            yu.Sifre =TextBox3.Text;
     
            UserCRUD ui = new UserCRUD();

            bilgi.InnerHtml = ui.kaydet(yu);
        }
    }
}