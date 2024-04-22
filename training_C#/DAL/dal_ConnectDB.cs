using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dal_ConnectDB
    {
        public static SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=Hung-PC\\SQLEXPRESS;Initial Catalog=qlns;Integrated Security=True");
            return conn;
        }
    }
}
