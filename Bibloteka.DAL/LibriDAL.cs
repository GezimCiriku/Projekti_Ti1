using Bibloteka.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteka.DAL
{
    public class LibriDAL
    {
        public static List<Libri_Autori> GetBooks()
        {
            List<Libri_Autori> listaLibrave = new List<Libri_Autori>();
            SqlConnection conn = DBHelper.GetConnection();


            try
            {
                string cmdText = "usp_GetBooks";
                SqlCommand SelectBooksCmd = new SqlCommand(cmdText, conn);
                SelectBooksCmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader reader = SelectBooksCmd.ExecuteReader();

                while (reader.Read())
                {
                    Kategoria objK = new Kategoria();
                    objK.Pershkrimi = reader["Kategoria"].ToString();

                    Libri objL = new Libri();
                    objL.LibriID = int.Parse(reader["LibriID"].ToString());
                    objL.Titulli = reader["Titulli"].ToString();
                    objL.ISBN = reader["ISBN"].ToString();
                    objL.ShtepiaBotuese = reader["ShtepiaBotuese"].ToString();
                    objL.Gjuha = reader["Gjuha"].ToString();
                    objL.Kategoria = objK;
                    objL.VitiBotimit = int.Parse(reader["VitiBotimit"].ToString());
                    objL.NrKopjeve = int.Parse(reader["NrKopjeve"].ToString());

                    Autori objA = new Autori();
                    string[] autor = reader["Autori"].ToString().Split(' ');
                    objA.AutoriID = int.Parse(reader["AutoriID"].ToString());
                    objA.Emri = autor[0];
                    objA.Mbiemri = autor[1];

                    Libri_Autori objLA = new Libri_Autori(objL, objA);

                    listaLibrave.Add(objLA);
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

            return listaLibrave;
        }

        public static bool Insert(Libri libri)
        {
            SqlConnection conn = DBHelper.GetConnection();
            try
            {
                string proc = "dbo.usp_InsertBook";

                SqlCommand cmd = new SqlCommand(proc, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LibriID", libri.LibriID);
                cmd.Parameters.AddWithValue("@Titulli", libri.Titulli);
                cmd.Parameters.AddWithValue("@Botuesi", libri.ShtepiaBotuese);
                cmd.Parameters.AddWithValue("@Gjuha", libri.Gjuha);
                cmd.Parameters.AddWithValue("@KategoriaID", libri.Kategoria.KategoriaID);
                cmd.Parameters.AddWithValue("@Pershkrimi", libri.Kategoria.Pershkrimi);
                cmd.Parameters.AddWithValue("@ISBN", libri.ISBN);
                cmd.Parameters.AddWithValue("@VitiBotimi", libri.VitiBotimit);
                cmd.Parameters.AddWithValue("@NrKopjeve", libri.NrKopjeve);
                cmd.Parameters.AddWithValue("@AutoriID", libri.AutoriID);

                conn.Open();
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
                //cmd.Dispose();
            }
        }

        public static bool UpdateLibri(Libri libri)
        {
            SqlConnection conn = DBHelper.GetConnection();
            string proc = "dbo.usp_UpdateLiber";
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                cmd.Connection = conn;

                SqlParameter sqlPrm = cmd.Parameters.Add("@ID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = libri.LibriID;

                sqlPrm = cmd.Parameters.Add("@Titulli", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = libri.Titulli;

                sqlPrm = cmd.Parameters.Add("@BotuesiID", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = libri.ShtepiaBotuese;

                sqlPrm = cmd.Parameters.Add("@GjuhaID", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = libri.Gjuha;

                sqlPrm = cmd.Parameters.Add("@KategoriaID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = libri.Kategoria.KategoriaID;

                sqlPrm = cmd.Parameters.Add("@ISBN", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = libri.ISBN;

                sqlPrm = cmd.Parameters.Add("@VitiBotimi", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = libri.VitiBotimit;

                sqlPrm = cmd.Parameters.Add("@NrKopjeve", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = libri.NrKopjeve;

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

        public static bool DeleteLibri(int libriID, int autoriID)
        {
            SqlConnection conn = DBHelper.GetConnection();
            string proc = "dbo.usp_DeleteLiber";
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();

                SqlParameter sqlPrm = cmd.Parameters.Add("@LiberID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = libriID;

                SqlParameter sqlPrm1 = cmd.Parameters.Add("@AutoriID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm1.Value = autoriID;

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
