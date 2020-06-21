using System;

namespace RocketProgramm
{
    public class qCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "q";
            }
        }

        public override void Execute(Location CurrentLocation)
        {
            Console.Write("(uwu)");
            Environment.Exit( 0 );
        }
    }
}