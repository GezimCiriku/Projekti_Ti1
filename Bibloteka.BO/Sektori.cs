using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class Sektori
    {
        public int SektID { get; set; }
        public string Pershkrimi { get; set; }

        public Sektori()
        {
        }

        public Sektori(int sektID, string pershkrimi)
        {
            SektID = sektID;
            Pershkrimi = pershkrimi;
        }
    }
}
