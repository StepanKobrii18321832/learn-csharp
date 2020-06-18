using System;

namespace RocketProgramm
{
    class HeaderG1 : RocketHeader
    {
        public int Human { get; private set; }
        public int Weight { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public Coordinates Space { get; set; }

        public HeaderG1()
        {
            Human = 0;
            Weight = 4000;
            Name = "G1";
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