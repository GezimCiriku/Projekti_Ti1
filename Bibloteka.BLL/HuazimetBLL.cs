using Bibloteka.BO;
using Bibloteka.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteka.BLL
{
   public class HuazimetBLL
    {

        public static void SelectHuazimet(DataGridView dg)
        {
            dg.DataSource = null;
            dg.DataSource = HuazimetDAL.GetLoans();
            dg.Columns[0].Visible = false;
            dg.Columns[1].Visible = false;
            dg.Columns[2].Visible = false;
            dg.Columns[3].Visible = false;
            dg.Columns[10].Visible = false;
            dg.Columns[9].Width = 165;
            dg.Columns[4].Width = 150;
            dg.Columns[5].Width = 150;

        }

        public static int ShtoHuazim(Huazimet huazimet)
        {
            return HuazimetDAL.Insert(huazimet);
        }

        public static int LargoHuazim(Huazimet huazimet)
        {
           return HuazimetDAL.LargoHuazim(huazimet);
        }

        public static void SelectHuazimetDetajet(DataGridView dg)
        {
            dg.DataSource = null;
            dg.DataSource = HuazimetDAL.GetLoans();
            dg.Columns[10].Visible = false;
        }

        public static void SearchHuazimet(DataGridView dg, string search)
        {
            dg.DataSource = null;
            dg.DataSource = HuazimetDAL.SearchLoans(search);
          //  dg.Columns[1].Visible = false;
        }
    }
}
