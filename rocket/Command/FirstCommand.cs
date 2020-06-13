using System;

namespace RocketProgramm
{
    public class FirstCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "test";
            }
        }

        public override void Execute()
        {
            Rocket FirstRocket = new Rocket();

            FirstRocket.Header = new HeaderA100();
            FirstRocket.Engine = new EngineHF450();
            FirstRocket.Body = new BodyKyev2();

            Rocket SecondRocket = new Rocket();

            SecondRocket.Header = new HeaderA150();
            SecondRocket.Engine = new EngineHF600();
            SecondRocket.Body = new BodyKyev();

            Console.WriteLine("\ntest first rocket\n");
            FirstRocket.Launch();
            

            Console.WriteLine("\ntest second rocket\n");
            SecondRocket.Launch();
            //Console.WriteLine("test command");
            //Environment.Exit( 0 );
        }
    }
}