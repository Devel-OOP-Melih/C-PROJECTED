using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_References
{
    internal class OtomobilUretim
    {
        public string renk;
        public string jant;
        private string model = "AUDI";
        private int EN = 3;
        private int BOY = 5;

        public string getModel()
        {
            return model;
        }

        public int getBoy()
        {
            return BOY;
        }

        public int getEn()
        {
            return EN;
        }

        //CONSTURACTOR METHOD(YAPICI METODLAR)
        public OtomobilUretim()
        {
        }
        public OtomobilUretim(string renk, string jant)
        {
            this.RENK = renk;
            this.JANT = jant;

        }

        public OtomobilUretim(string renk, string jant, int BOY)
        {
            this.RENK = renk;
            this.JANT = jant;
            this.BOY = 5;

        }

        //ENCAPSULATION(KAPSÜLLEME)
        public string RENK { get => renk; set => renk = value; }
        public string JANT { get => jant; set => jant = value; }
    }
}
