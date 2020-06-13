using System;
using System.Threading;

namespace RocketProgramm
{
    class RocketProgramm
    {
        public static void Main()
        {
            Rocket FirstRocket = new Rocket();

            FirstRocket.Header = new HeaderA100();
            FirstRocket.Engine = new EngineHF450();
            FirstRocket.Body = new BodyKyev();

            double speed = MaxSpeedRocket(FirstRocket.Engine.Power, FirstRocket.Weight);
            Console.WriteLine("Max speed = " + speed);
            if (speed > 50)
            {
                FirstRocket.Engine.Start();
                Thread.Sleep(5000);
                FirstRocket.Header.Message("things are good");
                FirstRocket.Engine.End();
            }
            else
            {
                Console.WriteLine("won't take off");
            }
            
        }

        public static double MaxSpeedRocket(int power, int mass)
        {
            return ((power * 62) / mass); 
        }
    }
}