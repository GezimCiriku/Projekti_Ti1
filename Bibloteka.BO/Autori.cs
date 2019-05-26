using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class Autori
    {
        public  int AutoriID { get; set; } 
        public string Emri { get; set; }
        public string Mbiemri { get; set; }


        public Autori()
        {
        }

        public Autori(int aID, string emri, string mbiemri)
        {
            AutoriID = aID;
            Emri = emri;
            Mbiemri = mbiemri;
        }

        public override string ToString()
        {
            return string.Join(" ", new string[] { Emri, Mbiemri });
        }

    }
}
