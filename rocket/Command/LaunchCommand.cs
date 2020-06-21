using System;

namespace RocketProgramm
{
    public class LaunchCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket launch";
            }
        }

        public override void Execute(Location CurrentLocation)
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < CurrentLocation.RocketList.Length; i++)
            {
                if (CurrentLocation.RocketList[i] != null) Console.WriteLine(i + " " + CurrentLocation.RocketList[i].Name);
                else Console.WriteLine(i);
            }

            if (CurrentLocation.RocketList.Length == 0) Console.WriteLine("null");

            string idstr = Console.ReadLine();
            int RocketNumber;
            bool notstr = Int32.TryParse(idstr, out RocketNumber);
            if (notstr && RocketNumber >= 0 && 
            RocketNumber < CurrentLocation.RocketList.Length && 
            CurrentLocation.RocketList[RocketNumber] != null) 
            CurrentLocation.RocketList[RocketNumber].Launch();
            else Console.WriteLine("its not rocket");
        }
    }
}