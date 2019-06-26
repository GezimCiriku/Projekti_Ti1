using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class Kopja
    {
        public int KopjaID { get; set; }
        public int LibriID { get; set; }
        public string GjendjaKopjes{ get; set; }
        public int PozicioniID { get; set; }
        public bool IsAvailable { get; set; }

        public Kopja()
        {
        }

        public Kopja(int kopjaID, int libriID, string gjendjaKopjes, int pozicioniID, bool isAvailable)
        {
            KopjaID = kopjaID;
            LibriID = libriID;
            GjendjaKopjes = gjendjaKopjes;
            PozicioniID = pozicioniID;
            IsAvailable = isAvailable;
        }

        public Kopja(int kopjaID, int libriID, string gjendjaKopjes, bool isAvailable)
        {
            KopjaID = kopjaID;
            LibriID = libriID;
            GjendjaKopjes = gjendjaKopjes;
            IsAvailable = isAvailable;
        }
    }
}
