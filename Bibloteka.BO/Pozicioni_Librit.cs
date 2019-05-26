using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class Pozicioni_Librit
    {
        public int PozicioniID { get; set; }
        public int DeptID { get; set; }
        public int SektID { get; set; }
        public string Rafti { get; set; }
        public string Rreshti { get; set; }
        public string Kolona { get; set; }

        public Pozicioni_Librit()
        {
        }

        public Pozicioni_Librit(int pozicioniID, int deptID, int sektID, string rafti,
                                string rreshti, string kolona)
        {
            PozicioniID = pozicioniID;
            DeptID = deptID;
            SektID = sektID;
            Rafti = rafti;
            Rreshti = rreshti;
            Kolona = kolona;
        }
    }
}
