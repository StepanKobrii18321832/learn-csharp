using System;

namespace RocketProgramm
{
    public class NewRocketCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "rocket new";
            }
        }

        public override void Execute()
        {
            bool flag = true;
            int RocketIndex = 0;
            for (int i = 0; i < Data.RocketList.Length; i++)
            {
                if (Data.RocketList[i] == null && flag) 
                {
                    RocketIndex = i;
                    flag = false;
                } 
            }
            if (flag)
            {
                Array.Resize(ref Data.RocketList, Data.RocketList.Length + 1);
                RocketIndex = Data.RocketList.Length - 1;
            } // search for free space in the array

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Data.RocketList[RocketIndex] = new Rocket(name);
            Console.WriteLine("Header list");
            for (int i = 0; i < Data.HeaderList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.HeaderList[i].Name);
            }
            flag = true;
            while (flag)
            {
                Console.Write("Header number: ");
                string idHeader = Console.ReadLine();
                int HeaderNumber = Convert.ToInt32(idHeader);
                if (Data.HeaderList[HeaderNumber] != null) 
                {
                    Data.RocketList[RocketIndex].Header = Data.HeaderList[HeaderNumber];
                    flag = false;
                }
                else 
                {
                    Console.WriteLine("its not header");
                }
            }

            Console.WriteLine("Body list");
            for (int i = 0; i < Data.BodyList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.BodyList[i].Name);
            }
            flag = true;
            while (flag)
            {
                Console.Write("Body number: ");
                string idBody = Console.ReadLine();
                int BodyNumber = Convert.ToInt32(idBody);
                if (Data.BodyList[BodyNumber] != null)
                {
                    Data.RocketList[RocketIndex].Body = Data.BodyList[BodyNumber];
                    flag = false;
                }
                else
                {
                    Console.WriteLine("its not body");
                }
            }


            Console.WriteLine("Engine list");
            for (int i = 0; i < Data.EngineList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.EngineList[i].Name);
            }
            flag = true;
            while (flag)
            {
                Console.Write("Engine number: ");
                string idEngine = Console.ReadLine();
                int EngineNumber = Convert.ToInt32(idEngine);
                if (Data.EngineList[EngineNumber] != null)
                {
                    Data.RocketList[RocketIndex].Engine = Data.EngineList[EngineNumber];
                    flag = false;
                }
            }

            Console.WriteLine("Rocket ctrated");
            // maybe this code is shit. I wrote this in the morning
        }
    }
}