using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimmilyonerolmakister
{
    internal class sorusinifi
    {
        public string metin { get; set; }
        public string[] secenekler { get; set; }
        public string dogrusecim { get; set; }
        public double sorudegeri { get; set; }

        public sorusinifi(string metin,string[]secenekler,string dogrusecim, double sorudegeri)
        {
            this.metin = metin;
            this.secenekler = secenekler;
            this.dogrusecim = dogrusecim;
            this.sorudegeri = sorudegeri;
        }

    }
}
