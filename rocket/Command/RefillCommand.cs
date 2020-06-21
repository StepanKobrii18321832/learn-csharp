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
            for (int i = 0; i < Data.RocketList.Length; i++)
            {
                if (Data.RocketList[i] != null) Console.WriteLine(i + " " + Data.RocketList[i].Name);
                else Console.WriteLine(i);
            }

            string idstr = Console.ReadLine();
            int RocketNumber;
            bool notstr = Int32.TryParse(idstr, out RocketNumber);
            if (notstr && RocketNumber >= 0 && 
            RocketNumber < Data.RocketList.Length && 
            Data.RocketList[RocketNumber] != null)
            await Task.Run(()=>Data.RocketList[RocketNumber].Refill(null));
            else
            {
                Console.WriteLine("its not rocket");
            }
        }
    }
}