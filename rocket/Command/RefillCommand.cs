using System;
using System.Threading;
using System.Threading.Tasks;

namespace RocketProgramm
{
    public class RefillCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket refill";
            }
        }

        public override async void Execute(Location CurrentLocation)
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < CurrentLocation.RocketList.Length; i++)
            {
                if (CurrentLocation.RocketList[i] != null) Console.WriteLine(i + " " + CurrentLocation.RocketList[i].Name);
                else Console.WriteLine(i);
            }

            string idstr = Console.ReadLine();
            int RocketNumber;
            bool notstr = Int32.TryParse(idstr, out RocketNumber);
            if (notstr && RocketNumber >= 0 && 
            RocketNumber < CurrentLocation.RocketList.Length && 
            CurrentLocation.RocketList[RocketNumber] != null)
            await Task.Run(()=>CurrentLocation.RocketList[RocketNumber].Refill(null));
            else
            {
                Console.WriteLine("its not rocket");
            }
        }
    }
}