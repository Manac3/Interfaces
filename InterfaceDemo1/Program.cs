using InterfaceDemo1.models;

namespace InterfaceDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek = new Kopek();
            kopek.Name = "Leo";
            kopek.Cinsiyet = Cinsiyet.Erkek;
            kopek.Yas = 3;
            kopek.Kos();
            kopek.Ye();


            Kedi kedi = new Kedi();
            kedi.Name = "Tekir";
            kedi.Cinsiyet = Cinsiyet.Dişi;
            kedi.Yas = 2;
            kedi.Uyu();
            kedi.Ye();
            kedi.Kos();

            Kanguru kanguru = new Kanguru();
            kanguru.Name = "zıpır";
            kanguru.Cinsiyet = Cinsiyet.Erkek;
            kanguru.Yas = 6;

            kanguru.Zipla();
            kanguru.Uyu();
            kanguru.Ye();



        }
    }
}