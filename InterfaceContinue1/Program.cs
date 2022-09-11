namespace InterfaceContinue1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDatabase database = new Oracle() //burda sql ya da oracle değişikliğinde
                                           //2 yer değiştiriyoruz onun yerine sadece bir yerde değişiklik yapabiliriz
                                           // Alanı IDatabase diye değiştirdik sadece oracle yazan yeri sql yapıp geçicez

            {
                Name = "Microsoft sql server.",
                Company = "Microsoft"

            };
            database.Update();
            database.Delete();
            Console.WriteLine(database.Name + " " + database.Company);
        }
    }

    interface IDatabase
    {
        string Name { get; set; }
        string Company { get; set; }
        void Create();
        void Read();
        void Update();
        void Delete();
        
    }
    class SqlServer : IDatabase
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public void Create()
        {
            Console.WriteLine("Created by SqlServer.");
        }
        public void Read()
        {
            Console.WriteLine("Readed by SqlServer.");
        }
        public void Update()
        {
            Console.WriteLine("Updated by SqlServer.");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted by SqlServer.");
        }
        //class içinde metodların sonuna noktalı virgül koymuyoz 


    }
    class Oracle : IDatabase
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public void Create()
        {
            Console.WriteLine("Created by Oracle Server.");
        }
        public void Read()
        {
            Console.WriteLine("Readed by Oracle Server.");
        }
        public void Update()
        {
            Console.WriteLine("Updated by Oracle Server.");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted by Oracle Server.");
        }
    }
}