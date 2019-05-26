using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class Pjesemarresit
    {
        public int PmID { get; set; }
        public int RoliID { get; set; }
      //public Roli Roli { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string NrTel { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Pjesemarresit()
        {
        }

        public Pjesemarresit(int pmID, int roliID,string emri, string mbiemri,
                             string nrTel, string email, string username, string password)
        {
            PmID = pmID;
            RoliID = roliID;
          //Roli = roli;
            Emri = emri;
            Mbiemri = mbiemri;
            NrTel = nrTel;
            Email = email;
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return String.Concat(Emri, " ", Mbiemri);
        }
    }
}
