using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
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
    }
}
