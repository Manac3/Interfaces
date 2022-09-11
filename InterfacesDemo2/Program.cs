namespace InterfacesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKoseliSekiller koseliSekil= null;
            Console.WriteLine("Şekil (1: dikdörtgen, 2: DikÜçgen, 3: daire): ");
            string sekil = Console.ReadLine();
            double taban;
            double yukseklik;
            if (sekil == "1" || sekil == "2")
            {
                Console.Write("Taban: ");
                taban = Convert.ToDouble(Console.ReadLine());
                Console.Write("Yükseklik: ");
                yukseklik = Convert.ToDouble(Console.ReadLine());
                switch (sekil)
                {
                    case "1":
                        koseliSekil = new Dikdortgen()
                        {
                            Taban = taban,
                            Yukseklik = yukseklik
                        };
                        break;
                    default:
                        koseliSekil = new DikUcgen()
                        {
                            Taban = taban,
                            Yukseklik = yukseklik
                        };
                        break;
                }
            }
            else
            {
                //TODO; //bak bu todo ya , eklenti gibi bi şey kısayolunu bul
            }
            Console.WriteLine($"Alan: {koseliSekil.AlanHesapla()}" +
                $"\nÇevre: {koseliSekil.CevreHesapla()}");
        }
    }
}