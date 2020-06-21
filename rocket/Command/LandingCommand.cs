using System;

namespace RocketProgramm
{
    public class LandingCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket landing";
            }
        }

        public override void Execute(Location CurrentLocation)
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < CurrentLocation.RocketListInOrbit.Length; i++)
            {
                if (CurrentLocation.RocketListInOrbit[i] != null) Console.WriteLine(i + " " + CurrentLocation.RocketListInOrbit[i].Name);
                else Console.WriteLine(i);
            }

            if (CurrentLocation.RocketListInOrbit.Length == 0) Console.WriteLine("null");
            

            string idstr = Console.ReadLine();
            int RocketNumber;
            bool notstr = Int32.TryParse(idstr, out RocketNumber);

            if (notstr && RocketNumber >= 0 && 
            RocketNumber < CurrentLocation.RocketListInOrbit.Length && 
            CurrentLocation.RocketListInOrbit[RocketNumber] != null) 
            CurrentLocation.RocketListInOrbit[RocketNumber].Landing();
            else Console.WriteLine("its not rocket");
        }
    }
}