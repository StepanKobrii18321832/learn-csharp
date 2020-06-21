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
            for (int i = 0; i < CurrentLocation.RocketListInOrbit.Length; i++)
            {
                if (CurrentLocation.RocketListInOrbit[i] != null) Console.WriteLine(i + " " + 
                CurrentLocation.RocketListInOrbit[i].Name + 
                ", Type: " + CurrentLocation.RocketListInOrbit[i].Header.Type +
                ", Orbit radius: " + CurrentLocation.RocketListInOrbit[i].Header.Space.OrbitRadius);
                else Console.WriteLine(i);
            }
        }
    }
}