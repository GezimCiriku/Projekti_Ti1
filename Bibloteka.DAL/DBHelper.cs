using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Bibloteka.DAL
{
    public class DBHelper
    {
        public static string ConnString()
        {
             return  ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnString());
        }

        public static void CloseConnection(SqlConnection objConn)
        {
            if (objConn.State == ConnectionState.Open)
                objConn.Close();
            objConn.Dispose();
        }
    }
}
