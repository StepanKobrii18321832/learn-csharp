using System;
using System.Threading;

namespace RocketProgramm
{
    class EngineHF600 : RocketEngine
    {
        public int Weight { get; private set; }
        public int Power { get; private set; }
        public int FuelConsumption { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public string Name { get; private set; }

        public EngineHF600()
        {
            Weight = 600;
            Power = 28000;
            FuelConsumption = 104;
            Color = "red";
            Material = "steel";
            Manufacturer = "Ukraine";
            Name = "HF600";
        }

        public void Start()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Engine started");
            Thread.Sleep(5000);
        }

        public void End()
        {
            Thread.Sleep(100);
            Console.WriteLine("Engine ended");
        }
    }
}