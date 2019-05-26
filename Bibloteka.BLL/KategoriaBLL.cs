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
    }
}
