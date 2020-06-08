using System; // підключення "бібліотеки"

namespace FirstProgramm // оголошення нової "бібліотеки" 
{
    class FirstProgramm
    {
        static void Main(string[] args) // метод
        {
            Console.WriteLine("programm start");
            Console.WriteLine(DateTime.Now); // Теперішній час
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.ReadKey();
        }
    }
}