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

        public bool FuelCostul; // этот костыль нужно поправить // я еще не придумал

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

        public void SendingSignal(string text, double currentDistance)
        {
            Header.Message("message from the rocket " + Name + "\n" + text + "\ndistance: " + 
            currentDistance + "\nfuel: " + Math.Round(100 * Fuel / Body.FuelVolume, 1) + "%");
        }

        private async void IntoOrbit()
        {
            Engine.Start();
            bool firstMessage = true;
            bool secondMessage = true;
            bool finishMessage = true; // ору с этого костыля // хотя я хз как правильно написать
            for (double currentDistance = 0; currentDistance < 100000; currentDistance += MaxSpeed)
            {
                Thread.Sleep(1000);
                Fuel -= Engine.FuelConsumption;
                if (firstMessage && currentDistance > 10000)
                {
                    await Task.Run(()=>SendingSignal("successful takeoff", currentDistance));
                    firstMessage = false;
                }
                if (secondMessage && currentDistance > 50000)
                {
                    await Task.Run(()=>SendingSignal("dumping empty fuel tanks", currentDistance));
                    secondMessage = false;
                }
                if (finishMessage && currentDistance > 95000)
                {
                    await Task.Run(()=>SendingSignal("entry into orbit", currentDistance));
                    finishMessage = false;
                }
            }
            await Task.Run(()=>SendingSignal("confirm the entry into orbit", Distance));
            Engine.End(); 
            InOrbit = true;
            Data.AddRocketInOrbit(this);
        }

        public async void Launch() // приятного полета по моему коду
        {
            if (FuelCostul) // чтобы я этого не видел // и что с этим делать теперь?
            {
                Fuel = Body.FuelVolume;
                FuelCostul = false;
                if (Header.Type == "cargo")
                {
                    Fuel += (Header.Weight - 1000) * 20;
                }
            }

            if (!InOrbit && MaxSpeed > 100 && Distance > 100000 && Fuel >= Body.FuelVolume)
            {
                Data.DeleteRocket(this); // bug
                await Task.Run(()=>IntoOrbit()); 
            }
            else if (MaxSpeed > 100 && Fuel >= Body.FuelVolume)
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
                    await Task.Run(()=>SendingSignal("rocket begins maneuver of entry into the atmosphere", currentDistance));
                    firstMessage = false;
                }
                if (secondMessage && currentDistance < 80000)
                {
                    await Task.Run(()=>SendingSignal("entrance to the atmosphere", currentDistance));
                    secondMessage = false;
                }
                if (parachuteMessage && currentDistance < 30000)
                {
                    await Task.Run(()=>SendingSignal("secondary parachute activation", currentDistance));
                    parachuteMessage = false;
                }
                if (finishMessage && currentDistance < 10000)
                {
                    await Task.Run(()=>SendingSignal("activation of the main parachute", currentDistance));
                    finishMessage = false;
                }
            }
            await Task.Run(()=>SendingSignal("landing was successful", Distance));
            Engine.End();
            InOrbit = false;
            Data.AddRocket(this);
        }

        public async void Landing()
        {
            if (InOrbit && Fuel >= 5000) // откуда это значение // нужно исправить
            {
                Data.DeleteRocketInOrbit(this);
                await Task.Run(()=>OnEarth()); 
            }
            else
            {
                Console.WriteLine("not enough fuel");
            }
        }

        public void Refill(Rocket rocket) // эта ракета должна быть на орбите
        {
            if (!InOrbit)
            {
                Data.DeleteRocket(this);
                Thread.Sleep(30000);
                FuelCostul = true;
                Console.WriteLine("Rocket " + Name + " refill done");
                Data.AddRocket(this);
            }
            else
            {
                double empty = (Header.Type == "passenger") ?
                Body.FuelVolume - Fuel :
                Body.FuelVolume + (Header.Weight - 1000) * 20 - Fuel;
                double setFuel = (rocket.Fuel > empty) ? empty : rocket.Fuel;
                double precentTank = 100 * (Fuel + setFuel) / Body.FuelVolume;


                Console.WriteLine("rocket can receive " + setFuel + 
                " fuel and fill its tanks " + precentTank + "%");
                Data.DeleteRocketInOrbit(rocket);
                Data.DeleteRocketInOrbit(this);

                Thread.Sleep(30000);
                rocket.Fuel -= setFuel;
                Fuel += setFuel;
                Console.WriteLine("Rocket " + Name + " refill done"); 
                Data.AddRocketInOrbit(rocket);
                Data.AddRocketInOrbit(this);
            }                                                        
        }                                                           
    }                                                              
}