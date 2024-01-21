using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2._2
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
            return this.model;
        }

        public int getBoy()
        {
          return this.BOY;
        }

        public int getEn()
        {
          return this.EN;
        }

        //CONSTURACTOR METHOD(YAPICI METODLAR)
        public OtomobilUretim()
        {
        }
        public OtomobilUretim(string renk, string jant)
        {
            this.renk = renk;
            this.jant = jant;

        }

        public OtomobilUretim(string renk, string jant, int BOY)
        {
            this.renk = renk;
            this.jant = jant;
            this.BOY = 5;

        }

        //ENCAPSULATION(KAPSÜLLEME)
        public string RENK { get => renk; set => renk = value; }
        public string JANT { get => jant; set => jant = value; }
    }
}
