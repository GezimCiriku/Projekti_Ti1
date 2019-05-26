using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class Kategoria
    {
        public int KategoriaID { get; set; }
        public string Pershkrimi { get; set; }

        public Kategoria()
        {
        }

        public Kategoria(int katID, string pershk)
        {
            KategoriaID = katID;
            Pershkrimi = pershk;
        }
    }
}
