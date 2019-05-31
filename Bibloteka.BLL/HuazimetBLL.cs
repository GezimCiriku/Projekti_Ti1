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
        }
    }
}
