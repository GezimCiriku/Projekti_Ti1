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
    public class LibriBLL
    {
        public static void SelectBooks(DataGridView dg)
        {
            dg.DataSource = null;
            dg.DataSource = LibriDAL.GetBooks();
        }

        public static int InsertBook(Libri libri)
        {
            return LibriDAL.Insert(libri);
        }

        public static bool Edit(Libri libri)
        {
            return LibriDAL.UpdateLibri(libri);
        }

        public static bool Delete(int libriID, int autoriID)
        {
            return LibriDAL.DeleteLibri(libriID,autoriID);
        }

    }
}
