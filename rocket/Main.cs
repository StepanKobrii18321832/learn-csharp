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

            Rocket SecondRocket = new Rocket();

            SecondRocket.Header = new HeaderA150();
            SecondRocket.Engine = new EngineHF600();
            SecondRocket.Body = new BodyKyev();

            Console.WriteLine("test first rocket");
            RocketLaunch(FirstRocket);

            Console.WriteLine("test second rocket");
            RocketLaunch(SecondRocket);
            
            
        }

        public static void RocketLaunch(Rocket rocket)
        {
            double speed = MaxSpeedRocket(rocket.Engine.Power, rocket.Weight);
            Console.WriteLine("Max speed = " + speed);
            if (speed > 50)
            {
                for (int i = 10; i > 0; i--)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
                rocket.Engine.Start();
                rocket.Header.Message("things are good");
                rocket.Engine.End();
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