using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Helikopter
    {
        private string kuyrukNumarası;
        private HeliMotor motor;
        private HeliDepo depo;
        private HeliPervane heliPervane;

        public Helikopter(string kuyrukNumarası, HeliMotor motor, HeliDepo depo, HeliPervane heliPervane)
        {
            this.KuyrukNumarası = kuyrukNumarası;
            this.Motor = motor;
            this.Depo = depo;
            this.HeliPervane = heliPervane;
        }

        public string KuyrukNumarası { get => kuyrukNumarası; set => kuyrukNumarası = value; }
        internal HeliMotor Motor { get => motor; set => motor = value; }
        internal HeliDepo Depo { get => depo; set => depo = value; }
        internal HeliPervane HeliPervane { get => heliPervane; set => heliPervane = value; }

        public void heliCalistir()
        {
            this.motor.motorCalissin();

        }
        public void heliDursun()
        {
            this.motor.motorDurdurulsun();
        }
    }

}
