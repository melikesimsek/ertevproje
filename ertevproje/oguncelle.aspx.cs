using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class oguncelle : System.Web.UI.Page
    {
        public string tarih(string tar)
        {
            string cevap;
            cevap = Convert.ToDateTime(tar).ToShortDateString();
            return cevap;
        }
        OgrenciCRUD oislem = new OgrenciCRUD();
        Ogrenci go = new Ogrenci();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//kayıt ilk yüklenişte hata versin
            {
                int ono = Convert.ToInt32(Request.QueryString["prm"]);
                go = oislem.getogr(ono);

                if (go.Cinsiyet == "Kadın")
                    RadioButton1.Checked = true;
                else
                    RadioButton2.Checked = true;
                TextBox7.Text = go.Ogr_no.ToString();
                TextBox1.Text = go.Ad.ToString();
                TextBox2.Text = go.Soyad.ToString();
                TextBox3.Text = tarih(Convert.ToString(go.D_tar));
                TextBox4.Text = go.Tel.ToString();
                TextBox5.Text = go.Email.ToString();
                TextBox6.Text = go.Adres.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string secim;
            if (RadioButton1.Checked)
                secim = RadioButton1.Text;
            else secim = RadioButton2.Text;

            go.Ad = TextBox1.Text;
            go.Soyad = TextBox2.Text;
            go.Cinsiyet = secim;
            go.D_tar = Convert.ToDateTime(TextBox3.Text);
            go.Tel = TextBox4.Text;
            go.Email = TextBox5.Text;
            go.Adres = TextBox6.Text;
            go.Dyeri = DropDownList1.SelectedItem.Value;
            go.Kursno =Convert.ToInt32( DropDownList2.SelectedItem.Value);
            go.Ogr_no = Convert.ToInt32(TextBox7.Text);


            if (oislem.guncelle(go))
            {
                Response.Redirect("oduzenle.aspx");
                bilgi.InnerHtml = "Güncelleme Başarılı";
            }
            else bilgi.InnerHtml = "Güncellenemedi.";
        }
    }
  
}