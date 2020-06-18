using System;
using System.Threading;

namespace RocketProgramm
{
    class EnginePRP5 : RocketEngine
    {
        public int Weight { get; private set; }
        public int Power { get; private set; }
        public int FuelConsumption { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public string Name { get; private set; }

        public EnginePRP5()
        {
            Weight = 250;
            Power = 14300;
            FuelConsumption = 59;
            Color = "red";
            Material = "steel";
            Manufacturer = "Ukraine";
            Name = "PRP-5";
        }

        public void Start()
        {
            Console.WriteLine("Engine started");
            Thread.Sleep(10000);
        }

        public void End()
        {
            Console.WriteLine("Engine ended");
        }
    }
}