using System;
using System.Threading;

namespace RocketProgramm
{
    class EngineHF600 : RocketEngine
    {
        public int Weight { get; private set; }
        public int Power { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }

        public EngineHF600()
        {
            Weight = 600;
            Power = 28000;
            Color = "red";
            Material = "steel";
            Manufacturer = "Ukraine";
        }

        public void Start()
        {
            Thread.Sleep(100);
            Console.WriteLine("50%");
            Thread.Sleep(100);
            Console.WriteLine("99%");
            Thread.Sleep(800);
            Console.WriteLine("100%");
            Thread.Sleep(100);
            Console.WriteLine("Engine started");
            Thread.Sleep(5000);
        }

        public void End()
        {
            Thread.Sleep(100);
            Console.WriteLine("50%");
            Thread.Sleep(100);
            Console.WriteLine("99%");
            Thread.Sleep(10);
            Console.WriteLine("100%");
            Console.WriteLine("Engine ended");
        }
    }
}