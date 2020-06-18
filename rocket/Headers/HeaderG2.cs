using System;

namespace RocketProgramm
{
    class HeaderG2 : RocketHeader
    {
        public int Human { get; private set; }
        public int Weight { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public Coordinates Space { get; set; }

        public HeaderG2()
        {
            Human = 0;
            Weight = 5700;
            Name = "G2";
            Type = "cargo";
        }

        public void Message(string text)
        {
            Console.WriteLine("\n\n\n\nopen-chanel\n\n\n\n");
            Console.WriteLine(text);
            Console.WriteLine("\n\n\n\nclose-chanel\n\n\n\n");
        }
    }
}