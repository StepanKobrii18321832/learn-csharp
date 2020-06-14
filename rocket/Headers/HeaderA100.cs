using System;
using System.Threading;

namespace RocketProgramm
{
    class HeaderA100 : RocketHeader
    {
        public int Human { get; private set; }
        public int Weight { get; private set; }
        public string Name { get; private set; }

        public HeaderA100()
        {
            Human = 2;
            Weight = 3500;
            Name = "A100";
        }

        public void Message(string text)
        {
            Thread.Sleep(1000);
            Console.WriteLine("\n\n\n\n-------open-chanel-------\n\n\n\n");
            Thread.Sleep(1000);
            Console.WriteLine(text);
            Thread.Sleep(1000);
            Console.WriteLine("\n\n\n\n-------close-chanel------\n\n\n\n");
            Thread.Sleep(1000);
        }
    }
}