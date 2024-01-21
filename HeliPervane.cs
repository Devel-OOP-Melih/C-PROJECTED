using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class HeliPervane
    {
        private int uzunluk;
        private int rpm;

        public HeliPervane(int uzunluk, int rpm)
        {
            this.Uzunluk = uzunluk;
            this.Rpm = rpm;
        }

        public int Uzunluk { get => uzunluk; set => uzunluk = value; }
        public int Rpm { get => rpm; set => rpm = value; }
    }
}
