using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    class Departamenti
    {
        public int DeptID { get; set; }
        public string Pershkrimi { get; set; }

        public Departamenti()
        {
        }

        public Departamenti(int dID, string pershkrimi)
        {
            DeptID = dID;
            Pershkrimi = pershkrimi;
        }
    }
}
