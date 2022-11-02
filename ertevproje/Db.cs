using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ertevproje
{
    public class Db
    {
        public SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["ertevegitimvt"].ConnectionString);
        public void ac()
        {
            baglanti.Open();
        }
        public void kapa()
        {
            baglanti.Close();

        }
    }
    
}