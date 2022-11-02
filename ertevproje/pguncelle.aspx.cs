using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class pguncelle : System.Web.UI.Page
    {
        public string tarih(string tar)
        {
            string cevap;
            cevap = Convert.ToDateTime(tar).ToShortDateString();
            return cevap;
        }
        PersonelCrud pislem = new PersonelCrud();
        Personel gp = new Personel();
        protected void Page_Load(object sender, EventArgs e)
        {
            int uno = Convert.ToInt32(Request.QueryString["prm"]);
            if (!IsPostBack)//kayıt ilk yüklenişte hata versin
            {
                int pno = Convert.ToInt32(Request.QueryString["prm"]);
                gp = pislem.getper(pno);           
                
                if (gp.Cins == "Kadın")
                    RadioButton1.Checked = true;
                else
                    RadioButton2.Checked = true;
                TextBox9.Text = gp.Perno.ToString();
                TextBox1.Text = gp.Ad.ToString();
                TextBox2.Text = gp.Soyad.ToString();
                TextBox3.Text = tarih(Convert.ToString(gp.Dtar));
                TextBox4.Text = gp.Tel.ToString();
                TextBox5.Text = gp.Email.ToString();
                TextBox6.Text = gp.Adres.ToString();
                TextBox7.Text = tarih(Convert.ToString(gp.Isgisristar));
                TextBox8.Text = gp.Maas.ToString();
     
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string secim;
            if (RadioButton1.Checked)
                secim = RadioButton1.Text;
            else secim = RadioButton2.Text;

            gp.Ad = TextBox1.Text;
            gp.Soyad = TextBox2.Text;
            gp.Cins = secim;
            gp.Dtar = Convert.ToDateTime(TextBox3.Text);
            gp.Tel = TextBox4.Text;
            gp.Email = TextBox5.Text;
            gp.Adres = TextBox6.Text;
            gp.Dyeri = DropDownList1.SelectedItem.Value;
            gp.Isgisristar = Convert.ToDateTime(TextBox7.Text);
            gp.Maas = Convert.ToInt32(TextBox8.Text);
            gp.Perno = Convert.ToInt32(TextBox9.Text);


            if (pislem.guncelle(gp))
            {
                Response.Redirect("pduzenle.aspx");
                bilgi.InnerHtml = "Güncelleme Başarılı";
            }
            else bilgi.InnerHtml = "Güncellenemedi.";
        }
    }
}