namespace InterfacesDemo2
{
    class DikUcgen : IKoseliSekiller
    {
        private double yukseklik;

        public double Taban { get; set; }
        public double Yukseklik { get; set; }
        public double AlanHesapla()
        {
            return Taban * Yukseklik / 2;
        }

        public double CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(Taban, 2) + Math.Pow(Yukseklik, 2));
            return hipotenus + Taban + Yukseklik;
        }
    }
}
