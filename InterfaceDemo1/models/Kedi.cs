using InterfaceDemo1.models.Bases;

namespace InterfaceDemo1.models
{
    internal class Kedi : IDortAyakliMemeli
    {
        public string Name { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public void Kos()
        {
            Console.WriteLine("Kedi Koşuyor");
        }

        public void Uyu()
        {
            Console.WriteLine("Kedi Uyur.");
        }

        public void Ye()
        {
            Console.WriteLine("Kedi Yer.");
        }
    }
}
