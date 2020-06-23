using System;

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

        public override void Execute(Location CurrentLocation)
        {
            for (int i = 0; i < Data.LocationList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.LocationList[i].NameLocation.Object.ToString());
            }
            string idstr = Console.ReadLine();
            int LocationNumber;
            bool notstr = Int32.TryParse(idstr, out LocationNumber);
            if (notstr && LocationNumber >= 0 && 
            LocationNumber < Data.LocationList.Length)
            {
                
            } 
            else
            {
                Console.WriteLine("not location");
            }
        }
    }
}