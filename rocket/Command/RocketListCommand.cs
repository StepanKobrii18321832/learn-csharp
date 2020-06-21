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

        public override void Execute(Location CurrentLocation)
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < Data.RocketList.Length; i++)
            {
                if (Data.RocketList[i] != null) Console.WriteLine(i + " " + 
                Data.RocketList[i].Name + " Type: " + Data.RocketList[i].Header.Type);
                else Console.WriteLine(i);
            }
        }
    }
}