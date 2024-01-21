using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class HeliDepo
    {
        private int hacim;

        public HeliDepo(int hacim)
        {
            this.Hacim = hacim;
        }

        public int Hacim { get => hacim; set => hacim = value; }
    }
}
