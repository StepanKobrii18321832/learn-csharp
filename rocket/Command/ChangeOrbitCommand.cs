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

        public override async void Execute()
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < Data.RocketListInOrbit.Length; i++)
            {
                if (Data.RocketListInOrbit[i] != null) Console.WriteLine(i + " " + Data.RocketListInOrbit[i].Name +
                ", Orbit: " + Data.RocketListInOrbit[i].Header.Space.OrbitRadius);
                else Console.WriteLine(i);
            }

            if (Data.RocketListInOrbit.Length == 0) Console.WriteLine("null");
            

            string idstr = Console.ReadLine();
            int RocketNumber;
            bool notstr = Int32.TryParse(idstr, out RocketNumber);

            if (notstr && RocketNumber >= 0 && 
            RocketNumber < Data.RocketListInOrbit.Length && 
            Data.RocketListInOrbit[RocketNumber] != null) 
            {
                Console.WriteLine("from " + Data.RocketListInOrbit[RocketNumber].Header.Space.OrbitRadius +
                " orbit to(1 - 3)");
                string orbitstr = Console.ReadLine();
                int orbitNumber;
                bool notstr2 = Int32.TryParse(orbitstr, out orbitNumber);
                if (notstr2 && orbitNumber >= 1 &&
                orbitNumber <= 3 && 
                orbitNumber != Data.RocketListInOrbit[RocketNumber].Header.Space.OrbitRadius)
                {
                    await Task.Run(()=>Data.RocketListInOrbit[RocketNumber].ChangeOrbit(orbitNumber)); // main
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