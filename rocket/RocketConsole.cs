using System;

namespace RocketProgramm
{
    partial class RocketProgramm
    {
        class RocketConsole
        {
            public Command[] List { get; set; }

            public RocketConsole() 
            {
                CurrentLocation = Data.LocationList[0];
            }
            public RocketConsole(Command[] list) : this()
            {
                List = list;
            }

            public Location CurrentLocation { get; set; }

            public void Run()
            {
                Console.WriteLine("(owo)");
                while(true)
                {
                    string str = Console.ReadLine();
                    bool flag = true;
                    for (int i = 0; i < List.Length; i++)
                    {
                        if (List[i].Contains(str, CurrentLocation)) flag = false;
                    }
                    if (flag) Console.WriteLine("unknown command");
                }
            }
        }     
    }
}