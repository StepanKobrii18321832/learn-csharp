using System;

namespace RocketProgramm
{
    public class NewRocketCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "new rocket";
            }
        }

        public override void Execute()
        {
            Data.RocketList[0].Launch();
        }
    }
}