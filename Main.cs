using System; 

namespace FirstProgramm 
{
    class User
    {
        public string name;
        public int age;

        public void get_info()
        {
            Console.WriteLine("name " + name + " age " + age);
        }

        public User()
        {
            name = "null";
            age = 0;
        }
        public User(string name)
        {
            this.name = name;
            age = 1;
        }
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class FirstProgramm
    {
        static void Main(string[] args) 
        {
            User alex = new User();
            User konb = new User("konb");
            User petro = new User("Petro", 26);

            alex.get_info();
            konb.get_info();
            petro.get_info();

            Console.WriteLine("programm start");
            Console.WriteLine(DateTime.Now); 
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.ReadKey();
        }
    }
}