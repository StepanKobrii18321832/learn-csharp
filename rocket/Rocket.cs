using System;
using System.Threading;
using System.Threading.Tasks;

namespace RocketProgramm
{
    class Rocket
    {
        public RocketHeader Header { get; set; }
        public RocketEngine Engine { get; set; }
        public RocketBody Body { get; set; }
        public int Weight
        {
            get
            {
                return (Header.Human * 100) + Header.Weight + Engine.Weight + Body.Weight + (Body.FuelVolume / 100);
            }
        }

        public double MaxSpeed
        {
            get
            {
                return ((Engine.Power * 70) / Weight);
            }
        }

        public double Distance
        {
            get
            {
                return (Body.FuelVolume / Engine.FuelConsumption) * MaxSpeed;
            }
        }

        public string Name { get; set; }
        public double Fuel;
        public Rocket() {}

        public Rocket (string name)
        {
            Name = name;
        }

        private async void IntoOrbit()
        {
            Engine.Start();
            bool firstMessage = true;
            bool secondMessage = true;
            bool finishMessage = true;
            for (double currentDistance = 0; currentDistance < 100000; currentDistance += MaxSpeed)
            {
                Thread.Sleep(1000);
                Fuel -= Engine.FuelConsumption;
                if (firstMessage && currentDistance > 10000)
                {
                    await Task.Run(()=>Header.Message("message from the rocket " + Name + "\nsuccessful takeoff\ndistance: " + 
                    currentDistance + "\nfuel: " + Math.Round(100 * Fuel / Body.FuelVolume, 1) + "%"));
                    firstMessage = false;
                }
                if (secondMessage && currentDistance > 50000)
                {
                    await Task.Run(()=>Header.Message("message from the rocket " + Name + "\ndumping empty fuel tanks\ndistance: " +
                    currentDistance + "\nfuel: " + Math.Round(100 * Fuel / Body.FuelVolume, 1) + "%"));
                    secondMessage = false;
                }
                if (finishMessage && currentDistance > 95000)
                {
                    await Task.Run(()=>Header.Message("message from the rocket " + Name + "\nentry into orbit\ndistance: " + 
                    currentDistance + "\nfuel: " + Math.Round(100 * Fuel / Body.FuelVolume, 1) + "%"));
                    finishMessage = false;
                }
            }
            await Task.Run(()=>Header.Message("message from the rocket " + Name + "\nconfirm the entry into orbit\nfuel: " +
            Math.Round(100 * Fuel / Body.FuelVolume, 1) + "%"));
            Engine.End();
        }

        public async void Launch()
        {
            Fuel = Body.FuelVolume;

            if (MaxSpeed > 100 && Distance > 100000)
            {
                Data.DeleteRocket(this);
                await Task.Run(()=>IntoOrbit()); 
            }
            else if (MaxSpeed > 100)
            {
                Console.WriteLine("won't go into orbit");
            }
            else
            {
                Console.WriteLine("won't take off");
            }

        }

    }
}