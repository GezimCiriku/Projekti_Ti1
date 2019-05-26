using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class Anetaresimi
    {
        public int AnetaresimiID { get; set; }
        public int PmID { get; set; }
      //public Pjesemarresit Pjesemarresit { get; set; }
        public int PakoID { get; set; }
      //public Pako Pako { get; set; }
        public DateTime DataRegjistrimit { get; set; }
        public DateTime DataSkadimit { get; set; }
        public bool IsActive { get; set; }

        public Anetaresimi()
        {
        }

        public Anetaresimi(int anetaresimiID, int pmID, int pakoID, 
                           DateTime dataRegjistrimit, DateTime dataSkadimit, bool isActive)
        {
            AnetaresimiID = anetaresimiID;
            PmID = pmID;
            PakoID = pakoID;
            DataRegjistrimit = dataRegjistrimit;
            DataSkadimit = dataSkadimit;
            IsActive = isActive;
        }
    }
}
