using System;

namespace RocketProgramm
{
    class HeaderA190 : RocketHeader
    {
        public int Human { get; private set; }
        public int Weight { get; private set; }
        public string Name { get; private set; }

        public HeaderA190()
        {
            Human = 2;
            Weight = 2000;
            Name = "A190";
        }

        public void Message(string text)
        {
            Console.WriteLine("\n\n\n\nopen-chanel\n\n\n\n");
            Console.WriteLine(text);
            Console.WriteLine("\n\n\n\nclose-chanel\n\n\n\n");
        }
    }
}