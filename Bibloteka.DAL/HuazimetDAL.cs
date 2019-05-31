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

                    Pjesemarresit objP = new Pjesemarresit();
                    string[] pm = reader["Lexuesi"].ToString().Split(' ');
                    objP.Emri = pm[0];
                    objP.Mbiemri = pm[1];

                    objL.PjesemarresiFullName = objP.Emri + " " + objP.Mbiemri;

                    objL.LibriID = int.Parse(reader["LibriID"].ToString());
                    objL.KopjaID =int.Parse( reader["KopjaID"].ToString());
                    objL.DataHuazimit= DateTime.Parse(reader["DataHuazimi"].ToString());

                    objL.AfatiKthimit = DateTime.Parse(reader["AfatiKthimit"].ToString());
                    //objL.DataKthimit = DateTime.Parse(reader["DataKthimit"].ToString());

                    objL.GjendjaLibritNeMarrje = reader["GjendjaLibritNeMarrje"].ToString();
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
    }
}
