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

        public static bool Insert(Kategoria kat)
        {
            SqlConnection conn = DBHelper.GetConnection();
            try
            {
                string proc = "dbo.usp_InsertKategori";

                SqlCommand cmd = new SqlCommand(proc, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
             
                cmd.Parameters.AddWithValue("@Pershkrimi", kat.Pershkrimi);
               
                conn.Open();
               

                if (cmd.ExecuteNonQuery()==0)
                {
                    return false;
                }
                return true;          
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

        public static List<Kategoria> GetCategories()
        {
            List<Kategoria> listaKategorive = new List<Kategoria>();
            SqlConnection conn = DBHelper.GetConnection();

            try
            {
                string cmdText = "usp_SelectKategories";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Kategoria objK = new Kategoria();
                    objK.KategoriaID = int.Parse(reader["KategoriaID"].ToString());
                    objK.Pershkrimi = reader["Pershkrimi"].ToString();

                    listaKategorive.Add(objK);
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

            return listaKategorive;
        }

        public static bool DeleteCategory(int KatID)
        {
            SqlConnection conn = DBHelper.GetConnection();
            string proc = "dbo.usp_DeleteCategory";
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();

                SqlParameter sqlPrm = cmd.Parameters.Add("@KategoriaID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = KatID;

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
