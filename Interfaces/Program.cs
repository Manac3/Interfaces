namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson person;
            Customer customer = new Customer();
            Student student = new Student()
            {
                Department = "Yazılım",
                Id = 1,
                Name = "Mehmet",
                Surname = "Anaç"
            };
            Console.WriteLine(student.Id + " " + student.Name + " " + student.Surname + " "+ student.Department + " ");

            person = new Student
            {
                Department = "Mimar",
                Id = 2,
                Name = "Orhan",
                Surname = "Alsaç"
            };
            ///Console.WriteLine(person.Department);//bunu yapamıyoruz çünkü personda department yok 
            //biz burda student new student yapsaydık department görürdük
            //ama biz person yapısı içinde bir student alanı açtık bu yüzden olmaz
            //zaten bu şekilde de genel olarak kullanılmaz
            //person nokta deyince person IPersona bağlı olduğğu için
            //Iperson özellikleri geliyor 
            Console.WriteLine(((Student)person).Department);
            //işte bu şekilde ulaşabiliriz departmenta
            //çünkü casting yaptık
            //veriyi veriye dönüştürdük
            //person değişkenini student değişkenine çevirerek kullandık


            //castingin 2. yöntemi
            Console.WriteLine(((Student)person).Name + " " + (person as Student).Department);
            //as kullanarak casting yaptık

            person = new Customer
            {
                CardNo = "1234",
                Surname = "Can",
                Name = "Emre",
                Id = 3
            };
            Console.WriteLine((person as Customer).CardNo);

        }
    }
    /// <summary>
    /// İnsan İnterface'i
    /// </summary>
    interface IPerson //soyut, abstract. new'lenemez
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        //string _IdentityNo; // interfacelere alan tanımlanamaz ama metod tanımlanabilir
    }
    class Customer : IPerson // somut, concrete, new'lenebilir
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNo { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
    }
}