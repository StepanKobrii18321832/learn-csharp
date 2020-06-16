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

        public bool FuelCostul;

        public bool InOrbit { get; private set; }
        public Rocket() 
        {
            InOrbit = false;
            FuelCostul = true;
        }

        public Rocket (string name) : this()
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
            InOrbit = true;
            bool flag = true;
            int RocketIndex = 0;
            for (int i = 0; i < Data.RocketListInOrbit.Length; i++)
            {
                if (Data.RocketListInOrbit[i] == null && flag) 
                {
                    RocketIndex = i;
                    flag = false;
                } 
            }
            if (flag)
            {
                Array.Resize(ref Data.RocketListInOrbit, Data.RocketListInOrbit.Length + 1);
                RocketIndex = Data.RocketListInOrbit.Length - 1;
            }
            Data.RocketListInOrbit[RocketIndex] = this;
        }

        public async void Launch()
        {
            if (FuelCostul)
            {
                Fuel = Body.FuelVolume;
                FuelCostul = false;
            }

            if (!InOrbit && MaxSpeed > 100 && Distance > 100000)
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

        public async void OnEarth()
        {
            Engine.Start();
            bool firstMessage = true;
            bool secondMessage = true;
            bool parachuteMessage = true;
            bool finishMessage = true;
            Fuel -= 1000;
            for (double currentDistance = 100000; currentDistance > 0; currentDistance -= MaxSpeed * 2)
            {
                Fuel -= 10;
                Thread.Sleep(1000);
                if (firstMessage && currentDistance < 99000)
                {
                    await Task.Run(()=>Header.Message("message from the rocket " + Name + "\nrocket begins maneuver of entry into the atmosphere\ndistance: " + 
                    currentDistance + "\nfuel: " + Math.Round(100 * Fuel / Body.FuelVolume, 1) + "%"));
                    firstMessage = false;
                }
                if (secondMessage && currentDistance < 80000)
                {
                    await Task.Run(()=>Header.Message("message from the rocket " + Name + "\nentrance to the atmosphere\ndistance: " +
                    currentDistance + "\nfuel: " + Math.Round(100 * Fuel / Body.FuelVolume, 1) + "%"));
                    secondMessage = false;
                }
                if (parachuteMessage && currentDistance < 30000)
                {
                    await Task.Run(()=>Header.Message("message from the rocket " + Name + "\nsecondary parachute activation\ndistance: " + 
                    currentDistance + "\nfuel: " + Math.Round(100 * Fuel / Body.FuelVolume, 1) + "%"));
                    parachuteMessage = false;
                }
                if (finishMessage && currentDistance < 10000)
                {
                    await Task.Run(()=>Header.Message("message from the rocket " + Name + "\nactivation of the main parachute\ndistance: " + 
                    currentDistance + "\nfuel: " + Math.Round(100 * Fuel / Body.FuelVolume, 1) + "%"));
                    finishMessage = false;
                }
            }
            await Task.Run(()=>Header.Message("message from the rocket " + Name + "\nlanding was successful\nfuel: " +
            Math.Round(100 * Fuel / Body.FuelVolume, 1) + "%"));
            Engine.End();
            InOrbit = false;
            bool flag = true;
            int RocketIndex = 0;
            for (int i = 0; i < Data.RocketList.Length; i++)
            {
                if (Data.RocketList[i] == null && flag) 
                {
                    RocketIndex = i;
                    flag = false;
                } 
            }
            if (flag)
            {
                Array.Resize(ref Data.RocketList, Data.RocketList.Length + 1);
                RocketIndex = Data.RocketList.Length - 1;
            }
            Data.RocketList[RocketIndex] = this;
        }

        public async void Landing()
        {
            if (InOrbit && Fuel >= 5000)
            {
                Data.DeleteRocketInOrbit(this);
                await Task.Run(()=>OnEarth()); 
            }
            else
            {
                Console.WriteLine("not enough fuel");
            }
        }

    }
}