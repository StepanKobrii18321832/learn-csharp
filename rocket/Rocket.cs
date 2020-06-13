using System;
using System.Threading;

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
                return (Header.Human * 100) + Header.Weight + Engine.Weight + Body.Weight;
            }
        }

        public double MaxSpeed
        {
            get
            {
                return ((Engine.Power * 62) / Weight);
            }
        }

        public double Distance
        {
            get
            {
                return (Body.FuelVolume / Engine.FuelConsumption) * MaxSpeed;
            }
        }

        public void Launch ()
        {
            Console.WriteLine("Max speed = " + MaxSpeed);
            Console.WriteLine("Max distance = " + Distance);

            if (MaxSpeed > 100 && Distance > 100000)
            {
                for (int i = 10; i > 0; i--)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
                Engine.Start();
                Header.Message("things are good");
                Engine.End();
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