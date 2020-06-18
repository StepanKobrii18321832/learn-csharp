using System;
using System.Threading;

namespace RocketProgramm
{
    class EngineRRP5 : RocketEngine
    {
        public int Weight { get; private set; }
        public int Power { get; private set; }
        public int FuelConsumption { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public string Name { get; private set; }

        public EngineRRP5()
        {
            Weight = 1000;
            Power = 49400;
            FuelConsumption = 140;
            Color = "red";
            Material = "steel";
            Manufacturer = "Ukraine";
            Name = "RRP-5";
        }

        public void Start()
        {
            Thread.Sleep(1000);
            Console.WriteLine("engine warming up");
            Thread.Sleep(10000);
            Console.WriteLine("Engine started");
            Thread.Sleep(10000);
        }

        public void End()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Engine ended");
        }
    }
}