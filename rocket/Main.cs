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

            Console.WriteLine("\ntest first rocket\n");
            FirstRocket.Launch();
            

            Console.WriteLine("\ntest second rocket\n");
            SecondRocket.Launch();
            
            
        }        
    }
}