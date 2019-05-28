using Bibloteka.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.DAL
{
    public class AutoriDAL
    {
        public static int Insert(Autori autori)
        {
            SqlConnection conn = DBHelper.GetConnection();

            try
            {
                string proc = "dbo.usp_InsertAutori";

                SqlCommand InsertAutoriCmd = new SqlCommand(proc, conn);
                InsertAutoriCmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlPrm = InsertAutoriCmd.Parameters.Add("@Emri", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = autori.Emri;

                sqlPrm = InsertAutoriCmd.Parameters.Add("@Mbiemri", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = autori.Mbiemri;

                sqlPrm = InsertAutoriCmd.Parameters.Add("@AutoriID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Output;


                conn.Open();

                InsertAutoriCmd.ExecuteNonQuery();

                int AutoriID = int.Parse(sqlPrm.Value.ToString());
                return AutoriID;
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
