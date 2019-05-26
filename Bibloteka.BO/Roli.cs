using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
   public class Roli
    {
        public int  RoliID { get; set; }
        public string Pershkrimi { get; set; }

        public Roli()
        {
        }

        public Roli(int roliID, string pershkrimi)
        {
            RoliID = roliID;
            Pershkrimi = pershkrimi;
        }
    }
}
