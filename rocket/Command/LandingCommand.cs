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

        public override void Execute()
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < Data.RocketListInOrbit.Length; i++)
            {
                if (Data.RocketListInOrbit[i] != null) Console.WriteLine(i + " " + Data.RocketListInOrbit[i].Name);
                else Console.WriteLine(i);
            }

            if (Data.RocketListInOrbit.Length == 0) Console.WriteLine("null");
            

            string idstr = Console.ReadLine();
            int RocketNumber;
            bool notstr = Int32.TryParse(idstr, out RocketNumber);

            if (notstr && RocketNumber >= 0 && 
            RocketNumber < Data.RocketListInOrbit.Length && 
            Data.RocketListInOrbit[RocketNumber] != null) 
            Data.RocketListInOrbit[RocketNumber].Landing();
            else Console.WriteLine("its not rocket");
        }
    }
}