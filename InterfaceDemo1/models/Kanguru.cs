using InterfaceDemo1.models.Bases;

namespace InterfaceDemo1.models
{
    class Kanguru : IKeseliMemeli
    {
        public string Name { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public void Uyu()
        {
            Console.WriteLine("Kanguru Uyur.");
        }

        public void Ye()
        {
            Console.WriteLine("Kanguru Yer.");
        }

        public void Zipla()
        {
            Console.WriteLine("Kanguru zıplar.");
        }
    }
}
