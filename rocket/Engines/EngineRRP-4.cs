using System;
using System.Threading;

namespace RocketProgramm
{
    class EngineRRP4 : RocketEngine
    {
        public int Weight { get; private set; }
        public int Power { get; private set; }
        public int FuelConsumption { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public string Name { get; private set; }

        public EngineRRP4()
        {
            Weight = 900;
            Power = 40600;
            FuelConsumption = 138;
            Color = "red";
            Material = "steel";
            Manufacturer = "Ukraine";
            Name = "RRP-4";
        }

        public void Start()
        {
            Thread.Sleep(1000);
            Console.WriteLine("25%");
            Thread.Sleep(1000);
            Console.WriteLine("50%");
            Thread.Sleep(1000);
            Console.WriteLine("75%");
            Thread.Sleep(1000);
            Console.WriteLine("100%");
            Thread.Sleep(2000);
            Console.WriteLine("Engine started");
            Thread.Sleep(5000);
        }

        public void End()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Engine ended");
        }
    }
}