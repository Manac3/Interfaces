

using InterfaceDemo1.models.Bases;

namespace InterfaceDemo1.models
{
    class Kopek : IDortAyakliMemeli
    {
        public string Name { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public void Kos()
        {
            Console.WriteLine("Köpek Koşuyor.");
        }

        public void Uyu()
        {
            Console.WriteLine("Köpek Uyuyor.");
        }

        public void Ye()
        {
            Console.WriteLine("Köpek Yiyor.");
        }
    }
}
