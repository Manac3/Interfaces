using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo2
{
    internal class Dikdortgen : IKoseliSekiller
    {
        public double Taban { get; set; }
        public double Yukseklik { get; set; }
        public double AlanHesapla()
        {
            return Taban * Yukseklik;
        }

        public double CevreHesapla()
        {
            double sonuc;
            sonuc = 2 * (Taban * Yukseklik);
            return sonuc;
        }
    }
}
