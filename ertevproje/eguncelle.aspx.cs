using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ertevproje
{
    public partial class eguncelle : System.Web.UI.Page
    {
        public string tarih(string tar)
        {
            string cevap;
            cevap = Convert.ToDateTime(tar).ToShortDateString();
            return cevap;
        }
        EgitimCRUD eislem = new EgitimCRUD();
        Egitim ge = new Egitim();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//kayıt ilk yüklenişte hata versin
            {
                int eno = Convert.ToInt32(Request.QueryString["prm"]);
                ge = eislem.getegt(eno);

                TextBox1.Text = ge.Kurs_no.ToString();
                TextBox4.Text = ge.Sure.ToString();
                TextBox5.Text = ge.Kontenjan.ToString();
                TextBox3.Text = tarih(Convert.ToString(ge.Bas_tar));
                TextBox7.Text = tarih(Convert.ToString(ge.Bit_tar));
                TextBox6.Text = ge.Icerik.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ge.Kurs_no = Convert.ToInt32(TextBox1.Text);
            ge.Kursadi = DropDownList3.SelectedItem.Text;
            ge.Sure = TextBox4.Text;
            ge.Kontenjan = TextBox5.Text;
            ge.Bas_tar = Convert.ToDateTime(TextBox3.Text);
            ge.Bit_tar = Convert.ToDateTime(TextBox7.Text);
            ge.Icerik = TextBox6.Text;

            if (eislem.guncelle(ge))
            {
              
                bilgi.InnerHtml = "Güncelleme Başarılı";
            }
            else bilgi.InnerHtml = "Güncellenemedi.";
        }
    }
}