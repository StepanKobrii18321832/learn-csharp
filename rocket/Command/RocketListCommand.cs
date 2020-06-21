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
            for (int i = 0; i < CurrentLocation.RocketList.Length; i++)
            {
                if (CurrentLocation.RocketList[i] != null) Console.WriteLine(i + " " + 
                CurrentLocation.RocketList[i].Name + " Type: " + CurrentLocation.RocketList[i].Header.Type);
                else Console.WriteLine(i);
            }
        }
    }
}