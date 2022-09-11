using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo1.models.Bases
{
    interface IKeseliMemeli //kanguru için yapıyoruz
    {
        string Name { get; set; }
        int Yas { get; set; }

        Cinsiyet Cinsiyet { get; set; }
        void Uyu();
        void Ye();
        void Zipla();
    }
}
