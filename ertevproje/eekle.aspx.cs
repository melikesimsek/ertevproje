using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class eekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Egitim ye = new Egitim();
            ye.Kurs_no = Convert.ToInt32(TextBox1.Text);
            ye.Kursadi = DropDownList3.SelectedItem.Text;
            ye.Sure = TextBox4.Text;
            ye.Kontenjan = TextBox5.Text;
            ye.Bas_tar = Convert.ToDateTime(TextBox3.Text);
            ye.Bit_tar = Convert.ToDateTime(TextBox7.Text);
            ye.Icerik = TextBox6.Text;
            EgitimCRUD ei = new EgitimCRUD();

            bilgi.InnerHtml = ei.kaydet(ye);
        }

    
    }
}