using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo2
{
    public class Daire : IYuvarlakSekil
    {
        public double YariCap { get; set; }
        public bool Pi3mu { get; set; } = true;

        //public double Pi 
        //{
        //    get
        //    {
        //        return Pi3mu ? 3 : Math.PI;
        //    }
        //}
        //bu kullanım temel bi alttaki kısa hali 

        public double Pi => Pi3mu ? 3 : Math.PI;

        public double AlanHesapla()
        {
            return Pi * Math.Pow(YariCap, 2);
        }

        public double CevreHesapla()
        {
            return 2 * Pi * YariCap;
        }
    }
}
