using Bibloteka.BO;
using Bibloteka.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteka.BLL
{
    public class KategoriaBLL
    {
        public static DataTable SelectKategories()
        {
            return KategoriaDAL.SelectKategories();
        }

        public static bool InsertCategory(Kategoria kat)
        {
            return KategoriaDAL.Insert(kat);
        }

        public static void SelectCategories(DataGridView dg)
        {
            dg.DataSource = null;
            dg.DataSource = KategoriaDAL.GetCategories();
        }


        public static bool Delete(int KatID)
        {
            return KategoriaDAL.DeleteCategory(KatID);
        }
    }
}
