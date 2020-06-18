using System;
using System.Threading;

namespace RocketProgramm
{
    class EngineHF800 : RocketEngine
    {
        public int Weight { get; private set; }
        public int Power { get; private set; }
        public int FuelConsumption { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public string Name { get; private set; }

        public EngineHF800()
        {
            Weight = 800;
            Power = 30000;
            FuelConsumption = 105;
            Color = "red";
            Material = "steel";
            Manufacturer = "Ukraine";
            Name = "HF800";
        }

        public void Start()
        {
            
            Console.WriteLine("Engine started");
            Thread.Sleep(2000);
        }

        public void End()
        {
            Console.WriteLine("Engine ended");
        }
    }
}