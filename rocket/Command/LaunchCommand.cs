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
                Console.WriteLine(i + " " + Data.RocketList[i].Name);
            }

            string idstr = Console.ReadLine();
            int RocketNumber = Convert.ToInt32(idstr);

            Data.RocketList[RocketNumber].Launch();
        }
    }
}