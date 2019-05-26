using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class Libri
    {
        public int LibriID { get; set; }
        public string Titulli { get; set; }
        public string ISBN { get; set; }
        public string ShtepiaBotuese { get; set; }
        public string Gjuha { get; set; }
        public Kategoria Kategoria { get; set; }
        public int VitiBotimit { get; set; }
        public int NrKopjeve { get; set; }
        public int AutoriID { get; set; }
        

        public Libri()
        {

        }

        public Libri(int libriID, string titulli, string iSBN, string shtepiaBotuese, string gjuha,
                     Kategoria kategoria, int vitiBotimit, int nrKopjeve, int autoriID)
        {
            LibriID = libriID;
            Titulli = titulli;
            ISBN = iSBN;
            ShtepiaBotuese = shtepiaBotuese;
            Gjuha = gjuha;
            Kategoria = kategoria;
            VitiBotimit = vitiBotimit;
            NrKopjeve = nrKopjeve;
            AutoriID = autoriID;
        }

        public Libri(int libriID, string titulli, string iSBN, string shtepiaBotuese, string gjuha, 
                     Kategoria kategoria, int vitiBotimit, int nrKopjeve)
        {
            LibriID = libriID;
            Titulli = titulli;
            ISBN = iSBN;
            ShtepiaBotuese = shtepiaBotuese;
            Gjuha = gjuha;
            Kategoria = kategoria;
            VitiBotimit = vitiBotimit;
            NrKopjeve = nrKopjeve;
        }
    }
}
