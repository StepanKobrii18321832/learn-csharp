using System;

namespace RocketProgramm
{
    class RocketHeader
    {
        public int Human { get; private set; }
        public int Weight { get; private set; }

        public RocketHeader()
        {
            Human = 2;
            Weight = 3500;
        }
        public int GetWeight()
        {
            return (Human * 100) + Weight;
        }

        public void Message(string text)
        {
            Console.WriteLine("-------open-chanel-------");
            Console.WriteLine(text);
            Console.WriteLine("-------close-chanel------");
        }
    }
}