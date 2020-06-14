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
            Console.WriteLine("> open-chanel");
            Console.WriteLine("> " + text);
            Console.WriteLine("> close-chanel");
        }
    }
}