using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_References
{
    internal class ElektrikliUretim : OtomobilUretim
    {
        private int sarjDurumu;

        public ElektrikliUretim(int sarjDurumu, string renk, string jant)
        {
            this.sarjDurumu = sarjDurumu;
            this.RENK = renk;
            this.JANT = jant;
        }

        public string sarjDurumuGoster()
        {
            return sarjDurumu + " kWh.";
        }

        public void sarjEt()
        {
            this.sarjDurumu = 250;
        }
    }
}
