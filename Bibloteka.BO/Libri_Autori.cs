using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    //klasa nderlidhese mes librit dhe autorit
    public class Libri_Autori
    {
        public int LibriID { get; set; }
        public string Titulli { get; set; }
        public string ISBN { get; set; }
        public string Botuesi { get; set; }
        public string Gjuha { get; set; }
        public string Kategoria { get; set; }
        public int VitiBotimit { get; set; }
        public int NrKopjeve { get; set; }
        public int AutoriID { get; set; } 
        public string Autori { get; set; }

        public Libri_Autori()
        {
        }

        public Libri_Autori(Libri l, Autori a)
        {
            Autori = a.ToString();
            LibriID = l.LibriID;
            Titulli = l.Titulli;
            Botuesi = l.ShtepiaBotuese;
            Gjuha = l.Gjuha;
            Kategoria = l.Kategoria.Pershkrimi;
            ISBN = l.ISBN;
            VitiBotimit = l.VitiBotimit;
            NrKopjeve = l.NrKopjeve;
            AutoriID = a.AutoriID;
            
        }
    }
}
