namespace Interfaces2
{
    class Program
    {
        //interface new`lenemez 
        static void Main(string[] args)
        {
            /*/IPersonManager personManager = new IPersonManager();
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();/*/


            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());


        }
    }

    interface IPersonManager
    {
        
        void Add();
        void Update();
    }

    //ingerits - class  ------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Musteri ekleme kodlari 
            Console.WriteLine("Musteri Eklendi!");

        }

        public void Update()
        {
            Console.WriteLine("Musteri Guncellendi!");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodlari
            Console.WriteLine("Personel Eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Personel Guncellendi!");
        }

    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Stajyer Guncellendi");
        }

    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

}