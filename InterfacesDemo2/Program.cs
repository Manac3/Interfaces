namespace InterfacesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKoseliSekiller koseliSekil = null;
            IYuvarlakSekil yuvarlakSekil = null;
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
                Console.WriteLine($"Alan: {koseliSekil.AlanHesapla()}" +
                $"\nÇevre: {koseliSekil.CevreHesapla()}");
            }
            else //3:Darire
            {

                Console.Write("Yarıçap: ");
                double yaricap = Convert.ToDouble(Console.ReadLine());
                Console.Write("Pî 3 mü? (e: evet h: hayır): ");
                bool pi3Mu = Console.ReadLine() == "e" ? true : false;
                yuvarlakSekil = new Daire()
                {
                    Pi3mu = pi3Mu,
                    YariCap = yaricap
                };
                Console.WriteLine($"Alan: {yuvarlakSekil.AlanHesapla()}" +
                $"\nÇevre: {yuvarlakSekil.CevreHesapla()}");

            }

        }
    }
}