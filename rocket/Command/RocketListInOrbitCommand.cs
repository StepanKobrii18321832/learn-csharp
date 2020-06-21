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

        public override void Execute(Location CurrentLocation)
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < Data.CurrentLocation.RocketListInOrbit.Length; i++)
            {
                if (Data.CurrentLocation.RocketListInOrbit[i] != null) Console.WriteLine(i + " " + 
                Data.CurrentLocation.RocketListInOrbit[i].Name + 
                ", Type: " + Data.CurrentLocation.RocketListInOrbit[i].Header.Type +
                ", Orbit radius: " + Data.CurrentLocation.RocketListInOrbit[i].Header.Space.OrbitRadius);
                else Console.WriteLine(i);
            }
        }
    }
}