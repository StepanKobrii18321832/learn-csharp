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
            for (int i = 0; i < CurrentLocation.RocketList.Length; i++)
            {
                if (CurrentLocation.RocketList[i] == null && flag) 
                {
                    RocketIndex = i;
                    flag = false;
                } 
            }
            if (flag)
            {
                Array.Resize(ref CurrentLocation.RocketList, CurrentLocation.RocketList.Length + 1);
                RocketIndex = CurrentLocation.RocketList.Length - 1;
            } // search for free space in the array

            Console.Write("Name: ");
            string name = Console.ReadLine();
            CurrentLocation.RocketList[RocketIndex] = new Rocket(name);
            Console.WriteLine("Header list");
            for (int i = 0; i < Data.HeaderList.Length; i++)
            {
                Console.WriteLine(i + " " + Data.HeaderList[i].Name);
            }
            flag = true;
            while (flag) // ВНИМАНИЕ слабонервным не смотреть
            {
                Console.Write("Header number: "); // здесь костыль)))0)
                string idHeader = Console.ReadLine();
                int HeaderNumber;
                bool notstrH = Int32.TryParse(idHeader, out HeaderNumber);
                if (notstrH && HeaderNumber >= 0 && HeaderNumber < Data.HeaderList.Length) 
                {
                    switch (HeaderNumber)
                    {
                        case 0: // я хз как создать новый экземпляр типом как экземпляр класса который в массиве 
                            CurrentLocation.RocketList[RocketIndex].Header = new HeaderA100(); 
                            break;
                        case 1: // это только для хедера
                            CurrentLocation.RocketList[RocketIndex].Header = new HeaderA150();
                            break;
                        case 2:
                            CurrentLocation.RocketList[RocketIndex].Header = new HeaderA190();
                            break;
                        case 3:
                            CurrentLocation.RocketList[RocketIndex].Header = new HeaderG1();
                            break;
                        case 4:
                            CurrentLocation.RocketList[RocketIndex].Header = new HeaderG2();
                            break;
                    }
                    //CurrentLocation.RocketList[RocketIndex].Header = CurrentLocation.HeaderList[HeaderNumber]; // нужно новый а не копия
                    CurrentLocation.RocketList[RocketIndex].Header.Space = new Coordinates(); // хз, если не свитч то не роботает
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
                int BodyNumber;
                bool notstrB = Int32.TryParse(idBody, out BodyNumber);
                if (notstrB && BodyNumber >= 0 && BodyNumber < Data.BodyList.Length)
                {
                    CurrentLocation.RocketList[RocketIndex].Body = Data.BodyList[BodyNumber];
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
                int EngineNumber;
                bool notstrE = Int32.TryParse(idEngine, out EngineNumber);
                if (notstrE && EngineNumber >= 0 && EngineNumber < Data.EngineList.Length)
                {
                    CurrentLocation.RocketList[RocketIndex].Engine = Data.EngineList[EngineNumber];
                    flag = false;
                }
            }

            Console.WriteLine("Rocket ctrated");
            // maybe this code is shit. I wrote this in the morning
        }
    }
}