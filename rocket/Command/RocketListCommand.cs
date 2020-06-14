using System;

namespace RocketProgramm
{
    public class RocketListCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket list";
            }
        }

        public override void Execute()
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < Data.RocketList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.RocketList[i].Name);
            }
        }
    }
}