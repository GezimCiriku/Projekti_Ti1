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
    public static class HuazimetDAL
    {

        public static List<Huazimet> GetLoans()
        {
            List<Huazimet> listaHuazimeve = new List<Huazimet>();
            SqlConnection conn = DBHelper.GetConnection();

            try
            {
                string cmdText = "usp_GetHuazimet";
                SqlCommand SelectBooksCmd = new SqlCommand(cmdText, conn);
                SelectBooksCmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader reader = SelectBooksCmd.ExecuteReader();

                while (reader.Read())
                {
                   
                    Huazimet objL = new Huazimet();

                    objL.HuazimiID = int.Parse(reader["HuazimiID"].ToString());

                    objL.PmID = int.Parse(reader["PmID"].ToString());

                    objL.LibriID = int.Parse(reader["LibriID"].ToString());

                    objL.KopjaID = int.Parse(reader["KopjaID"].ToString());

                    Pjesemarresit objP = new Pjesemarresit();
                    string[] pm = reader["Lexuesi"].ToString().Split(' ');
                    objP.Emri = pm[0];
                    objP.Mbiemri = pm[1];

                    objL.Lexuesi = objP.Emri + " " + objP.Mbiemri;

                    objL.Libri = reader["Titulli"].ToString();

                    objL.DataHuazimit= DateTime.Parse(reader["DataHuazimi"].ToString());

                    objL.AfatiKthimit = DateTime.Parse(reader["AfatiKthimit"].ToString());

                    try
                    {
                        objL.DataKthimit = DateTime.Parse(reader["DataKthimit"].ToString());
                    }
                    catch (Exception)
                    {
                        objL.DataKthimit = null;
                    }

                    objL.Verejtje = reader["Verejtje"].ToString();

                    //objL.GjendjaLibritNeMarrje = reader["GjendjaLibritNeMarrje"].ToString();
                    // objL.GjendjaLibritNeKthim = reader["GjendjaLibritNeKthim"].ToString();
                    //objL.Verejtje = reader["Verejtje"].ToString();
                    //objL.Gjoba =Convert.ToDecimal( reader["Gjoba"].ToString());

                    listaHuazimeve.Add(objL);
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

            return listaHuazimeve;
        }

        public static List<Huazimet> SearchLoans(string search)
        {
            List<Huazimet> listaHuazimet = new List<Huazimet>();
            SqlConnection conn = DBHelper.GetConnection();

            try
            {
                string cmdText = "usp_SearchLoans";
                SqlCommand SearchLoans = new SqlCommand(cmdText, conn);
                SearchLoans.CommandType = CommandType.StoredProcedure;


                SqlParameter sqlPrm = SearchLoans.Parameters.Add("@search", SqlDbType.VarChar);
                sqlPrm.Direction = ParameterDirection.Input;
                sqlPrm.Value = search;

                conn.Open();

                SqlDataReader reader = SearchLoans.ExecuteReader();

                while (reader.Read())
                {
                    Huazimet objL = new Huazimet();

                    objL.HuazimiID = int.Parse(reader["HuazimiID"].ToString());

                    objL.PmID = int.Parse(reader["PmID"].ToString());

                    objL.LibriID = int.Parse(reader["LibriID"].ToString());

                    objL.KopjaID = int.Parse(reader["KopjaID"].ToString());

                    Pjesemarresit objP = new Pjesemarresit();
                    string[] pm = reader["Lexuesi"].ToString().Split(' ');
                    objP.Emri = pm[0];
                    objP.Mbiemri = pm[1];

                    objL.Lexuesi = objP.Emri + " " + objP.Mbiemri;

                    objL.Libri = reader["Titulli"].ToString();

                    objL.DataHuazimit = DateTime.Parse(reader["DataHuazimi"].ToString());

                    objL.AfatiKthimit = DateTime.Parse(reader["AfatiKthimit"].ToString());

                    try
                    {
                        objL.DataKthimit = DateTime.Parse(reader["DataKthimit"].ToString());
                    }
                    catch (Exception)
                    {
                        objL.DataKthimit = null;
                    }

                    objL.Verejtje = reader["Verejtje"].ToString();


                    listaHuazimet.Add(objL);
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

            return listaHuazimet;
        }

        public static int LargoHuazim(Huazimet huazimet)
        {
            SqlConnection conn = DBHelper.GetConnection();

            try
            {
                string proc = "dbo.usp_KtheLibrin";

                SqlCommand cmd = new SqlCommand(proc, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
   
                cmd.Parameters.AddWithValue("@LibriID", huazimet.LibriID);

                cmd.Parameters.AddWithValue("@KopjaID", huazimet.KopjaID);

                cmd.Parameters.AddWithValue("@PmID", huazimet.PmID);

                cmd.Parameters.AddWithValue("@DataKthimit", huazimet.DataKthimit);

                cmd.Parameters.AddWithValue("@Verejtje", huazimet.Verejtje);

                cmd.Parameters.AddWithValue("@HuazimKthim", huazimet.Huazim_Kthim);

                SqlParameter sqlPrm = cmd.Parameters.Add("@Return", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Output;


                conn.Open();
                cmd.ExecuteNonQuery();


                int Return = int.Parse(sqlPrm.Value.ToString());
                return Return;
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

        public static int Insert(Huazimet huazimet)
        {
            SqlConnection conn = DBHelper.GetConnection();
            try
            {
                string proc = "dbo.usp_InsertHuazim";

                SqlCommand cmd = new SqlCommand(proc, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // cmd.Parameters.AddWithValue("@LibriID", libri.LibriID);
                cmd.Parameters.AddWithValue("@LibriID", huazimet.LibriID);
                cmd.Parameters.AddWithValue("@KopjaID", huazimet.KopjaID);
                cmd.Parameters.AddWithValue("@PmID", huazimet.PmID);
                cmd.Parameters.AddWithValue("@DataHuazimit", huazimet.DataHuazimit);
                cmd.Parameters.AddWithValue("@AfatiKthimit", huazimet.AfatiKthimit);
             //   cmd.Parameters.AddWithValue("@DataKthimit", huazimet.DataKthimit);
                cmd.Parameters.AddWithValue("@Verejtje", String.Empty);
                cmd.Parameters.AddWithValue("@HuazimKthim", huazimet.Huazim_Kthim);


                SqlParameter sqlPrm = cmd.Parameters.Add("@HuazimiID", SqlDbType.Int);
                sqlPrm.Direction = ParameterDirection.Output;


                conn.Open();
                cmd.ExecuteNonQuery();

                int HuazimiID = int.Parse(sqlPrm.Value.ToString());
                return HuazimiID;
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
    }
}
