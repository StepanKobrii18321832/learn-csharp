using System;
using System.Threading;
using System.Threading.Tasks;

namespace RocketProgramm
{
    public class GetFuelCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket get fuel";
            }
        }

        public override async void Execute(Location CurrentLocation)
        {
            Console.WriteLine("Rocket list (main)");
            for (int i = 0; i < CurrentLocation.RocketListInOrbit.Length; i++)
            {
                if (CurrentLocation.RocketListInOrbit[i] != null) Console.WriteLine(i + " " + CurrentLocation.RocketListInOrbit[i].Name);
                else Console.WriteLine(i);
            }
            string idstr = Console.ReadLine();
            int RocketNumber;
            bool notstr = Int32.TryParse(idstr, out RocketNumber);
            if (notstr && RocketNumber >= 0 && 
            RocketNumber < CurrentLocation.RocketListInOrbit.Length && 
            CurrentLocation.RocketListInOrbit[RocketNumber] != null) {}
            else
            {
                Console.WriteLine("its not rocket");
            }

            Console.WriteLine("Rocket list (secondary)");
            for (int i = 0; i < CurrentLocation.RocketListInOrbit.Length; i++)
            {
                if (CurrentLocation.RocketListInOrbit[i] != null && CurrentLocation.RocketListInOrbit[i].Header.Type == "cargo") 
                Console.WriteLine(i + " " + CurrentLocation.RocketListInOrbit[i].Name);
                else Console.WriteLine(i);
            }
            idstr = Console.ReadLine();
            int RocketNumberCargo;
            notstr = Int32.TryParse(idstr, out RocketNumberCargo);
            if (notstr && RocketNumberCargo >= 0 && 
            RocketNumberCargo < CurrentLocation.RocketListInOrbit.Length && 
            CurrentLocation.RocketListInOrbit[RocketNumberCargo] != null &&
            CurrentLocation.RocketListInOrbit[RocketNumberCargo].Header.Type == "cargo") 
            {
                await Task.Run(()=>CurrentLocation.RocketListInOrbit[RocketNumber].Refill(CurrentLocation.RocketListInOrbit[RocketNumberCargo]));
            }
            else
            {
                Console.WriteLine("its not rocket");
            }
        }
    }
}