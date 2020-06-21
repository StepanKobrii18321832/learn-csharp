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

        public override void Execute(Location CurrentLocation)
        {
            bool flag = true;
            int RocketIndex = 0;
            for (int i = 0; i < Data.CurrentLocation.RocketList.Length; i++)
            {
                if (Data.CurrentLocation.RocketList[i] == null && flag) 
                {
                    RocketIndex = i;
                    flag = false;
                } 
            }
            if (flag)
            {
                Array.Resize(ref Data.CurrentLocation.RocketList, Data.CurrentLocation.RocketList.Length + 1);
                RocketIndex = Data.CurrentLocation.RocketList.Length - 1;
            } // search for free space in the array

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Data.CurrentLocation.RocketList[RocketIndex] = new Rocket(name);
            Console.WriteLine("Header list");
            for (int i = 0; i < Data.CurrentLocation.HeaderList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.CurrentLocation.HeaderList[i].Name);
            }
            flag = true;
            while (flag) // ВНИМАНИЕ слабонервным не смотреть
            {
                Console.Write("Header number: "); // здесь костыль)))0)
                string idHeader = Console.ReadLine();
                int HeaderNumber;
                bool notstrH = Int32.TryParse(idHeader, out HeaderNumber);
                if (notstrH && HeaderNumber >= 0 && HeaderNumber < Data.CurrentLocation.HeaderList.Length) 
                {
                    switch (HeaderNumber)
                    {
                        case 0: // я хз как создать новый экземпляр типом как экземпляр класса который в массиве 
                            Data.CurrentLocation.RocketList[RocketIndex].Header = new HeaderA100(); 
                            break;
                        case 1: // это только для хедера
                            Data.CurrentLocation.RocketList[RocketIndex].Header = new HeaderA150();
                            break;
                        case 2:
                            Data.CurrentLocation.RocketList[RocketIndex].Header = new HeaderA190();
                            break;
                        case 3:
                            Data.CurrentLocation.RocketList[RocketIndex].Header = new HeaderG1();
                            break;
                        case 4:
                            Data.CurrentLocation.RocketList[RocketIndex].Header = new HeaderG2();
                            break;
                    }
                    //Data.CurrentLocation.RocketList[RocketIndex].Header = Data.CurrentLocation.HeaderList[HeaderNumber]; // нужно новый а не копия
                    Data.CurrentLocation.RocketList[RocketIndex].Header.Space = new Coordinates(); // хз, если не свитч то не роботает
                    flag = false;
                }
                else 
                {
                    Console.WriteLine("its not header");
                }
            }

            Console.WriteLine("Body list");
            for (int i = 0; i < Data.CurrentLocation.BodyList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.CurrentLocation.BodyList[i].Name);
            }
            flag = true;
            while (flag)
            {
                Console.Write("Body number: ");
                string idBody = Console.ReadLine();
                int BodyNumber;
                bool notstrB = Int32.TryParse(idBody, out BodyNumber);
                if (notstrB && BodyNumber >= 0 && BodyNumber < Data.CurrentLocation.BodyList.Length)
                {
                    Data.CurrentLocation.RocketList[RocketIndex].Body = Data.CurrentLocation.BodyList[BodyNumber];
                    flag = false;
                }
                else
                {
                    Console.WriteLine("its not body");
                }
            }


            Console.WriteLine("Engine list");
            for (int i = 0; i < Data.CurrentLocation.EngineList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.CurrentLocation.EngineList[i].Name);
            }
            flag = true;
            while (flag)
            {
                Console.Write("Engine number: ");
                string idEngine = Console.ReadLine();
                int EngineNumber;
                bool notstrE = Int32.TryParse(idEngine, out EngineNumber);
                if (notstrE && EngineNumber >= 0 && EngineNumber < Data.CurrentLocation.EngineList.Length)
                {
                    Data.CurrentLocation.RocketList[RocketIndex].Engine = Data.CurrentLocation.EngineList[EngineNumber];
                    flag = false;
                }
            }

            Console.WriteLine("Rocket ctrated");
            // maybe this code is shit. I wrote this in the morning
        }
    }
}