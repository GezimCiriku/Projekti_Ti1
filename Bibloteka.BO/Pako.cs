using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class Pako
    {
        public int PakoID { get; set; }
        public decimal Cmimi { get; set; }
        public int Kohezgjatja { get; set; } //njesi = muaj
        public string Pershkrimi { get; set; }

        public Pako()
        {
        }

        public Pako(int pakoID, decimal cmimi, int kohezgjatja, string pershkrimi)
        {
            PakoID = pakoID;
            Cmimi = cmimi;
            Kohezgjatja = kohezgjatja;
            Pershkrimi = pershkrimi;
        }
    }
}
