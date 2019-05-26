using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bibloteka.DAL
{
    public class RoliDal
    {
        public static int GetRoleID(string username, string password)
        {
            SqlConnection conn = DBHelper.GetConnection();
            try
            {
                string cmdText = "usp_LoginRole";

                SqlCommand GetLoginRole = new SqlCommand(cmdText, conn);
                GetLoginRole.CommandType = CommandType.StoredProcedure;

                GetLoginRole.Parameters.AddWithValue("@Username", username);
                GetLoginRole.Parameters.AddWithValue("@Password", password);

                conn.Open();
                int result = (int)GetLoginRole.ExecuteScalar();
                return result;
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
