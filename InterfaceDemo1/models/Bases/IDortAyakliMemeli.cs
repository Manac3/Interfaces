

namespace InterfaceDemo1.models.Bases
{
    //interface IMemeli //insan(1. grup olsun), kedi - köpek (2.Grup olsun ), kanguru(3.grup olsun)
    //    //biz bunu 4 kategoride yapacağımıza kanguruyu ayrı interface e alırsak daha çok özellik kullanabiliriz
    //{
    //    string Name { get; set; }
    //    int Yas { get; set; }

    //    Cinsiyet Cinsiyet { get; set; }
    //    void Uyu();
    //    void Ye();
    //    //void Kos(); kanguru için geçerli değil oluşturmayız
    //    //void Konus(); sadece insan için geçerli o yüzden tanımlanamaz

    //}
    interface IDortAyakliMemeli 
    {
        string Name { get; set; }
        int Yas { get; set; }

        Cinsiyet Cinsiyet { get; set; }
        void Uyu();
        void Ye();
        void Kos(); 
    }
}
