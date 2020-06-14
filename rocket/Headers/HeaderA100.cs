using System;

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
            Console.WriteLine("-------open-chanel-------");
            Console.WriteLine(text);
            Console.WriteLine("-------close-chanel------");
        }
    }
}