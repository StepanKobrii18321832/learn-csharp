using System;

namespace RocketProgramm
{
    public class LaunchCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket launch";
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
            if (Data.RocketList[RocketNumber] != null) Data.RocketList[RocketNumber].Launch();
            else Console.WriteLine("its not rocket");
        }
    }
}