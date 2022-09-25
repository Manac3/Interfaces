//SOLID I: İnterface Segregation

interface ICalisan
{
    void Calis();


}
interface IInsanCalisan
{
    void YemekYer();
    void MaasAlir();
}

class Calisan : ICalisan, IInsanCalisan
{
    public void Calis()
    {
        Console.WriteLine("Çalışır ");
    }

    public void MaasAlir()
    {
        Console.WriteLine("Maaş Alır. ");
    }

    public void YemekYer()
    {
        Console.WriteLine("Yemek Yer. ");
    }
}

class Yonetici : ICalisan, IInsanCalisan
{
    public void Calis()
    {
        Console.WriteLine("Yönetici Çalışır.");
    }

    public void MaasAlir()
    {
        Console.WriteLine("Yönetici Maaş Alır. ");
    }

    public void YemekYer()
    {
        Console.WriteLine("Yönetici Yemek Yer. ");
    }
}
class Robot : ICalisan
{
    public void Calis()
    {
        Console.WriteLine("Robot Çalışır ");
    }
}
//işte bu yapıya biz interacesegregation diyoruz bi kaç interface oluşturup
//bu interfaceleri farklı classlara implement ediyoruz
//2 interface veya daha çok interfacei bi classa implement edebiliriz

