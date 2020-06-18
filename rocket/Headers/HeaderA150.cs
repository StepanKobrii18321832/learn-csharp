using System;
using System.Threading;

namespace RocketProgramm
{
    class HeaderA150 : RocketHeader
    {
        public int Human { get; private set; }
        public int Weight { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public Coordinates Space { get; set; }

        public HeaderA150()
        {
            Human = 2;
            Weight = 3300;
            Name = "A150";
            Type = "passenger";
        }

        public void Message(string text)
        {
            Thread.Sleep(500);
            Console.WriteLine("\n\n\n\n> open-chanel\n\n\n\n");
            Thread.Sleep(500);
            Console.WriteLine("> " + text);
            Thread.Sleep(500);
            Console.WriteLine("\n\n\n\n> close-chanel\n\n\n\n");
            Thread.Sleep(500);
        }
    }
}