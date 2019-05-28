using Bibloteka.BO;
using Bibloteka.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BLL
{
    public class AutoriBLL
    {
        public static int InsertAutor(Autori autori)
        {
            return AutoriDAL.Insert(autori);
        }
    }
}
