using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class basvuru : System.Web.UI.Page
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
            Ogrenci yo = new Ogrenci();
            yo.Ad = TextBox1.Text;
            yo.Soyad = TextBox2.Text;
            yo.Cinsiyet = secim;
            yo.D_tar = Convert.ToDateTime(TextBox3.Text);
            yo.Dyeri = DropDownList1.SelectedItem.Value;
            yo.Tel = TextBox4.Text;
            yo.Email = TextBox5.Text;
            yo.Adres = TextBox6.Text;
            yo.Kursno = Convert.ToInt32(DropDownList2.SelectedItem.Value);


            OgrenciCRUD oi = new OgrenciCRUD();

            bilgi.InnerHtml = oi.kaydet(yo);
        }
    }
}