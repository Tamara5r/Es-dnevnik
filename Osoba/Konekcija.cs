using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Osoba
{
    class Konekcija
    {

        static public SqlConnection Connect()
        {
            string CS;
            CS = ConfigurationManager.ConnectionStrings["kuca"].ConnectionString;
            SqlConnection conn = new SqlConnection(CS);
            return conn;
        }
    }
}
