using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BO
{
    public class Huazimet
    {
        public int HuazimiID { get; set; }
        public int LibriID { get; set; }
        public int KopjaID { get; set; }
        public int PmID { get; set; }
        public DateTime DataHuazimit { get; set; }
        public DateTime AfatiKthimit { get; set; }
        public DateTime DataKthimit { get; set; }
        public string GjendjaLibritNeMarrje { get; set; }
        public string GjendjaLibritNeKthim { get; set; }
        public string Verejtje { get; set; }
        public decimal Gjoba { get; set; }
        public char Huazim_Kthim { get; set; } //varesisht a kthen librin apo mer, kemi H ose K
    }
}
