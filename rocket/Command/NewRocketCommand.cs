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
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Data.RocketList[RocketIndex] = new Rocket(name);
            //element rocket read and create
            Console.WriteLine("Header list");
            for (int i = 0; i < Data.HeaderList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.HeaderList[i].Name);
            }
            string idHeader = Console.ReadLine();
            int HeaderNumber = Convert.ToInt32(idHeader);

            Console.WriteLine("Body list");
            for (int i = 0; i < Data.BodyList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.BodyList[i].Name);
            }
            string idBody = Console.ReadLine();
            int BodyNumber = Convert.ToInt32(idBody);

            Console.WriteLine("Engine list");
            for (int i = 0; i < Data.EngineList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.EngineList[i].Name);
            }
            string idEngine = Console.ReadLine();
            int EngineNumber = Convert.ToInt32(idEngine);

            Console.WriteLine("Rocket ctrated");

            Data.RocketList[RocketIndex].Header = Data.HeaderList[HeaderNumber];
            Data.RocketList[RocketIndex].Body = Data.BodyList[BodyNumber];
            Data.RocketList[RocketIndex].Engine = Data.EngineList[EngineNumber];
        }
    }
}