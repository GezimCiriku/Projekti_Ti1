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

        public static int Insert(Pjesemarresit pm)
        {
            SqlConnection conn = DBHelper.GetConnection();
            try
            {
                string proc = "dbo.usp_InsertPjesemarresi";

                SqlCommand cmd = new SqlCommand(proc, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                SqlParameter sqlPrm = cmd.Parameters.Add("@RoliID", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.RoliID;

                sqlPrm = cmd.Parameters.Add("@Emri", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.Emri;

                sqlPrm = cmd.Parameters.Add("@Mbiemri", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.Mbiemri;

                sqlPrm = cmd.Parameters.Add("@NrTel", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.NrTel;

                sqlPrm = cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.Email;

                sqlPrm = cmd.Parameters.Add("@DataRegj", SqlDbType.Date);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.DataRegjistrimit;

                sqlPrm = cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.Username;

                sqlPrm = cmd.Parameters.Add("@Passwordi", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.Password;

                sqlPrm = cmd.Parameters.Add("@PmID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteScalar();

                int PmID = int.Parse(sqlPrm.Value.ToString());
                return PmID;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DBHelper.CloseConnection(conn);
                //cmd.Dispose();
            }
        }

        public static List<Pjesemarresit> GetPm(int RoliID)
        {
            List<Pjesemarresit> listaPm = new List<Pjesemarresit>();
            SqlConnection conn = DBHelper.GetConnection();

            try
            {
                string cmdText = "usp_GetPm";
                SqlCommand SelectPm = new SqlCommand(cmdText, conn);
                SelectPm.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlPrm = SelectPm.Parameters.Add("@RoliID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = RoliID;

                conn.Open();

                SqlDataReader reader = SelectPm.ExecuteReader();

                while (reader.Read())
                {
                    Pjesemarresit objPm = new Pjesemarresit();
                    objPm.PmID = int.Parse(reader["PmID"].ToString());
                    objPm.Emri = reader["Emri"].ToString();
                    objPm.Mbiemri = reader["Mbiemri"].ToString();
                    objPm.NrTel = reader["NrTel"].ToString();
                    objPm.Email = reader["Email"].ToString();

                    objPm.DataRegjistrimit = Convert.ToDateTime(reader["DataRregjistrimit"].ToString());
                    objPm.Username = reader["Username"].ToString();
                    objPm.Password = reader["Passwordi"].ToString();

                    listaPm.Add(objPm);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                DBHelper.CloseConnection(conn);
            }
            return listaPm;
        }

        public static bool UpdatePm(Pjesemarresit pm)
        {
            SqlConnection conn = DBHelper.GetConnection();
            string proc = "dbo.usp_UpdatePm";
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                cmd.Connection = conn;

                SqlParameter sqlPrm = cmd.Parameters.Add("@ID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.PmID;

                sqlPrm = cmd.Parameters.Add("@RoliID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.RoliID;

                sqlPrm = cmd.Parameters.Add("@Emri", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.Emri;

                sqlPrm = cmd.Parameters.Add("@Mbiemri", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.Mbiemri;

                sqlPrm = cmd.Parameters.Add("@NrTel", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.NrTel;

                sqlPrm = cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.Email;

                sqlPrm = cmd.Parameters.Add("@DataRregj", SqlDbType.Date);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.DataRegjistrimit;

                sqlPrm = cmd.Parameters.Add("@Username", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.Username;

                sqlPrm = cmd.Parameters.Add("@Password", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = pm.Password;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DBHelper.CloseConnection(conn);
                cmd.Dispose();
            }
        }

        public static List<Pjesemarresit> SearchPm(string search, int RoliID)
        {
            List<Pjesemarresit> listaPm = new List<Pjesemarresit>();
            SqlConnection conn = DBHelper.GetConnection();

            try
            {
                string cmdText = "usp_SearchPm";
                SqlCommand SearchPm = new SqlCommand(cmdText, conn);
                SearchPm.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlPrm = SearchPm.Parameters.Add("@RoliID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = RoliID;

                sqlPrm = SearchPm.Parameters.Add("@search", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = search;

                conn.Open();

                SqlDataReader reader = SearchPm.ExecuteReader();

                while (reader.Read())
                {
                    Pjesemarresit objPm = new Pjesemarresit();
                    objPm.PmID = int.Parse(reader["PmID"].ToString());                  
                    objPm.Emri = reader["Emri"].ToString();
                    objPm.Mbiemri = reader["Mbiemri"].ToString();
                    objPm.NrTel = reader["NrTel"].ToString();
                    objPm.Email = reader["Email"].ToString();

                    objPm.DataRegjistrimit = Convert.ToDateTime(reader["DataRregjistrimit"].ToString());
                    objPm.Username = reader["Username"].ToString();
                    objPm.Password = reader["Passwordi"].ToString();

                    listaPm.Add(objPm);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                DBHelper.CloseConnection(conn);
            }
            return listaPm;
        }

        public static bool DeletePm(int PmID)
        {
            SqlConnection conn = DBHelper.GetConnection();
            string proc = "dbo.usp_DeletePm";
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();

                SqlParameter sqlPrm = cmd.Parameters.Add("@PmID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = PmID;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
