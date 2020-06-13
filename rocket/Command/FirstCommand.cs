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
            

            Console.WriteLine("\ntest first rocket\n");
            Data.RocketList[0].Launch();
            

            Console.WriteLine("\ntest second rocket\n");
            Data.RocketList[1].Launch();
        }
    }
}