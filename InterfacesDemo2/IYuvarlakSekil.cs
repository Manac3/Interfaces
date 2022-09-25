using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo2
{
    public interface IYuvarlakSekil : IHesapla
    {
        double YariCap { get; set; }   
        bool Pi3mu { get; set; }
       
    }
}
