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
            for (int i = 0; i < Data.CurrentLocation.RocketList.Length; i++)
            {
                if (Data.CurrentLocation.RocketList[i] != null) Console.WriteLine(i + " " + 
                Data.CurrentLocation.RocketList[i].Name + " Type: " + Data.CurrentLocation.RocketList[i].Header.Type);
                else Console.WriteLine(i);
            }
        }
    }
}