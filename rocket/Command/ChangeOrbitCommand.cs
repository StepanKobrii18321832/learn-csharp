using System;
using System.Threading;
using System.Threading.Tasks;

namespace RocketProgramm
{
    public class ChangeOrbitCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket change orbit";
            }
        }

        public override async void Execute(Location CurrentLocation)
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < CurrentLocation.RocketListInOrbit.Length; i++)
            {
                if (CurrentLocation.RocketListInOrbit[i] != null) Console.WriteLine(i + " " + CurrentLocation.RocketListInOrbit[i].Name +
                ", Orbit: " + CurrentLocation.RocketListInOrbit[i].Header.Space.OrbitRadius);
                else Console.WriteLine(i);
            }

            if (CurrentLocation.RocketListInOrbit.Length == 0) Console.WriteLine("null");
            

            string idstr = Console.ReadLine();
            int RocketNumber;
            bool notstr = Int32.TryParse(idstr, out RocketNumber);

            if (notstr && RocketNumber >= 0 && 
            RocketNumber < CurrentLocation.RocketListInOrbit.Length && 
            CurrentLocation.RocketListInOrbit[RocketNumber] != null) 
            {
                Console.WriteLine("from " + CurrentLocation.RocketListInOrbit[RocketNumber].Header.Space.OrbitRadius +
                " orbit to(1 - " + CurrentLocation.NameLocation.OrbitRadius + ")");
                string orbitstr = Console.ReadLine();
                int orbitNumber;
                bool notstr2 = Int32.TryParse(orbitstr, out orbitNumber);
                if (notstr2 && orbitNumber >= 1 &&
                orbitNumber <= CurrentLocation.NameLocation.OrbitRadius && 
                orbitNumber != CurrentLocation.RocketListInOrbit[RocketNumber].Header.Space.OrbitRadius)
                {
                    await Task.Run(()=>CurrentLocation.RocketListInOrbit[RocketNumber].ChangeOrbit(orbitNumber)); // main
                }
                else
                {
                    Console.WriteLine("no orbit");
                }
            }
            else Console.WriteLine("its not rocket");
        }
    }
}