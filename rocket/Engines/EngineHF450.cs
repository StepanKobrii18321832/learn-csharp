using System;
using System.Threading;

namespace RocketProgramm
{
    class EngineHF450 : RocketEngine
    {
        public int Weight { get; private set; }
        public int Power { get; private set; }
        public int FuelConsumption { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public string Name { get; private set; }

        public EngineHF450()
        {
            Weight = 500;
            Power = 23000;
            FuelConsumption = 100;
            Color = "yellow";
            Material = "steel";
            Manufacturer = "Ukraine";
            Name = "HF450";
        }

        public void Start()
        {
            Thread.Sleep(200);
            Console.WriteLine("50%");
            Thread.Sleep(200);
            Console.WriteLine("99%");
            Thread.Sleep(2000);
            Console.WriteLine("100%");
            Thread.Sleep(100);
            Console.WriteLine("Engine started");
            Thread.Sleep(5000);
        }

        public void End()
        {
            Thread.Sleep(200);
            Console.WriteLine("50%");
            Thread.Sleep(100);
            Console.WriteLine("99%");
            Thread.Sleep(10);
            Console.WriteLine("100%");
            Console.WriteLine("Engine ended");
        }
    }
}