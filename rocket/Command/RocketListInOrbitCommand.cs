using System;

namespace RocketProgramm
{
    public class RocketListInOrbitCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket list in orbit";
            }
        }

        public override void Execute()
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < Data.RocketListInOrbit.Length; i++)
            {
                if (Data.RocketListInOrbit[i] != null) Console.WriteLine(i + " " + 
                Data.RocketListInOrbit[i].Name + " Type: " + Data.RocketListInOrbit[i].Header.Type);
                else Console.WriteLine(i);
            }
        }
    }
}