using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonerTakip
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source = BilgisayarAdi; Initial Catalog = DboTonerTakip; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
