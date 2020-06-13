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
            Array.Resize(ref Data.RocketList, Data.RocketList.Length + 1);
            int RocketIndex = Data.RocketList.Length - 1;
            Data.RocketList[RocketIndex] = new Rocket();
            //element rocket read and create
        }
    }
}