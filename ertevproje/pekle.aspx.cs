using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class pekle : System.Web.UI.Page
    {
        string secim;
        protected void Page_Load(object sender, EventArgs e)
        { 
            if (RadioButton1.Checked)
                secim = RadioButton1.Text;
            else secim = RadioButton2.Text;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Personel yp = new Personel();
            yp.Ad = TextBox1.Text;
            yp.Soyad =TextBox2.Text;
            yp.Cins = secim;
            yp.Dtar = Convert.ToDateTime(TextBox3.Text);
            yp.Dyeri = DropDownList1.SelectedItem.Value;
            yp.Tel = TextBox4.Text;
            yp.Email = TextBox5.Text;
            yp.Adres = TextBox6.Text;
            yp.Isgisristar = Convert.ToDateTime(TextBox7.Text);
            yp.Maas = Convert.ToInt32(TextBox8.Text);
            PersonelCrud pi = new PersonelCrud();
            yp.Foto = TextBox9.Text;
            yp.Birim = TextBox10.Text;
            bilgi.InnerHtml = pi.kaydet(yp);
        }
    }
}