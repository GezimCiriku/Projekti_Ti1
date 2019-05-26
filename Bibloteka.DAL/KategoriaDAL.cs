using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.DAL
{
    public class KategoriaDAL
    {
        public static DataTable SelectKategories()
        {
            SqlConnection conn = DBHelper.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                string cmdText = "usp_SelectKategories";

                SqlCommand SelectKategoriesCmd = new SqlCommand(cmdText, conn);

                SqlDataAdapter sda = new SqlDataAdapter(SelectKategoriesCmd);

                conn.Open();
                sda.Fill(dt);
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                DBHelper.CloseConnection(conn);
            }

            return dt;
        }
    }
}
