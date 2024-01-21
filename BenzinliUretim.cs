using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_References
{
    internal class BenzinliUretim : OtomobilUretim
    {
        private int yakitDurumu;

        public BenzinliUretim(int yakitDurumu, string renk, string jant)
        {
            this.yakitDurumu = yakitDurumu;
            this.JANT = jant;
            this.RENK = renk;
        }

        public string yakitDurumuGoster()
        {
            return yakitDurumu + " Lt";
        }

        public void depoFulle()
        {
            this.yakitDurumu = 55;
        }
    }
}
