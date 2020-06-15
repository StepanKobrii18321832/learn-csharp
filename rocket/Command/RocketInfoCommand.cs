using System;

namespace RocketProgramm
{
    public class RocketInfoCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket info";
            }
        }

        public override void Execute()
        {
            Console.WriteLine("Rocket list");
            for (int i = 0; i < Data.RocketList.Length; i++)
            {
                if (Data.RocketList[i] != null) Console.WriteLine(i + " " + Data.RocketList[i].Name);
                else Console.WriteLine(i);
            }

            string idstr = Console.ReadLine();
            int RocketNumber = Convert.ToInt32(idstr);
            if (Data.RocketList[RocketNumber] != null)
            {
                Rocket RI = Data.RocketList[RocketNumber]; // RI - RocketInfo

                Console.WriteLine("Rocket Name: " + RI.Name + "\n");
                Console.WriteLine("Header: " + RI.Header.Name + "\n");
                Console.WriteLine("Weight: " + RI.Header.Weight);
                Console.WriteLine("Human: " + RI.Header.Human + "\n");
                Console.WriteLine("Body: " + RI.Body.Name + "\n");
                Console.WriteLine("Weight: " + RI.Body.Weight);
                Console.WriteLine("Fuel volume: " + RI.Body.FuelVolume + "\n");
                Console.WriteLine("Engine: " + RI.Engine.Name + "\n");
                Console.WriteLine("Weight: " + RI.Engine.Weight);
                Console.WriteLine("Power: " + RI.Engine.Power);
                Console.WriteLine("Fuel consumption: " + RI.Engine.FuelConsumption);
            }
            else
            {
                Console.WriteLine("its not rocket");
            }
        }
    }
}