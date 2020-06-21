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
            for (int i = 0; i < Data.RocketList.Length; i++)
            {
                if (Data.RocketList[i] != null) Console.WriteLine(i + " " + Data.RocketList[i].Name);
                else Console.WriteLine(i);
            }

            if (Data.RocketList.Length == 0) Console.WriteLine("null");

            string idstr = Console.ReadLine();
            int RocketNumber;
            bool notstr = Int32.TryParse(idstr, out RocketNumber);
            if (notstr && RocketNumber >= 0 && 
            RocketNumber < Data.RocketList.Length && 
            Data.RocketList[RocketNumber] != null) 
            Data.RocketList[RocketNumber].Launch();
            else Console.WriteLine("its not rocket");
        }
    }
}