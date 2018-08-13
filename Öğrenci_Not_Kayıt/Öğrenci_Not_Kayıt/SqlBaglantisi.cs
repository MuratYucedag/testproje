using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Öğrenci_Not_Kayıt
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-B1PO435\SQLEXPRESS;Initial Catalog=OgrenciNotKayıtDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
