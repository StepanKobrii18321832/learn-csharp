using System;

namespace RocketProgramm
{
    public class CurrentLocationCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "location current";
            }
        }

        public override void Execute(Location CurrentLocation)
        {
            Console.WriteLine(CurrentLocation.NameLocation.Object.ToString());
        }
    }
}