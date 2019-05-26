using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Bibloteka.BO;


namespace Bibloteka.DAL
{
    public class PjesemarresiDAL
    {
        public static bool ValidateLogin(string username, string password)
        {
            SqlConnection conn = DBHelper.GetConnection();

            try
            {
                string cmdText = "usp_ValidateLogin";

                SqlCommand ValidateLoginCmd = new SqlCommand(cmdText, conn);
                ValidateLoginCmd.CommandType = CommandType.StoredProcedure;

                ValidateLoginCmd.Parameters.AddWithValue("@Username", username);
                ValidateLoginCmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                int result = (int)ValidateLoginCmd.ExecuteScalar();
                return result == 1;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DBHelper.CloseConnection(conn);
            }
        }
    }
}
