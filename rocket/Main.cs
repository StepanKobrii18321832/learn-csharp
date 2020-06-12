using System;
using System.Threading;

namespace RocketProgramm
{
    class RocketProgramm
    {
        public static void Main()
        {
            Rocket FirstRocket = new Rocket();

            FirstRocket.Header = new RocketHeader();
            FirstRocket.Engine = new EngineHF450();

            int speed = MaxSpeedRocket(FirstRocket.Engine.Power, FirstRocket.Weight);
            Console.WriteLine("Max speed = " + speed);
            if (speed > 50)
            {
                FirstRocket.Engine.Start();
            }
            else
            {
                Console.WriteLine("won't take off");
            }
            Thread.Sleep(5000);
            FirstRocket.Header.Message("things are good");
            FirstRocket.Engine.End();
        }

        public static int MaxSpeedRocket(int power, int mass)
        {
            return (mass / power * 5) + 100; 
        }
    }
}