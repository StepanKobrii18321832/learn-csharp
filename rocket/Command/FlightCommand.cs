using System;
using System.Threading;
using System.Threading.Tasks;

namespace RocketProgramm
{
    public class FlightCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket flight";
            }
        }

        public override async void Execute(Location CurrentLocation)
        {
            Console.WriteLine("Rocket list");
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
            CurrentLocation.RocketListInOrbit[RocketNumber] != null)
            {
                for (int i = 0; i < Data.LocationList.Length; i++)
                {
                    Console.WriteLine(i + " " + Data.LocationList[i].NameLocation.Object.ToString());
                }
                idstr = Console.ReadLine();
                int LocationNumber;
                notstr = Int32.TryParse(idstr, out LocationNumber);
                if (notstr && LocationNumber >= 0 && 
                LocationNumber < Data.LocationList.Length)
                {
                    await Task.Run(()=>CurrentLocation.RocketListInOrbit[RocketNumber].Flight(LocationNumber));
                } 
                else
                {   
                    Console.WriteLine("not location");  
                }
            }
            else
            {
                Console.WriteLine("its not rocket");
            }
            
        }
    }
}