using System;
using System.Threading;

namespace RocketProgramm
{
    class EnginePRP4 : RocketEngine
    {
        public int Weight { get; private set; }
        public int Power { get; private set; }
        public int FuelConsumption { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public string Name { get; private set; }

        public EnginePRP4()
        {
            Weight = 300;
            Power = 12900;
            FuelConsumption = 61;
            Color = "red";
            Material = "steel";
            Manufacturer = "Ukraine";
            Name = "PRP-4";
        }

        public void Start()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Engine started");
            Thread.Sleep(5000);
        }

        public void End()
        {
            Console.WriteLine("Engine ended");
        }
    }
}