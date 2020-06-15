using System;

namespace RocketProgramm
{
    partial class RocketProgramm
    {
        class RocketConsole
        {
            public Command[] List { get; set; }

            public RocketConsole() {}
            public RocketConsole(Command[] list) {
                List = list;
            }

            public void Run()
            {
                Console.WriteLine("(owo)");
                while(true)
                {
                    string str = Console.ReadLine();
                    bool flag = true;
                    for (int i = 0; i < List.Length; i++)
                    {
                        if (List[i].Contains(str)) flag = false;
                    }
                    if (flag) Console.WriteLine("unknown command");
                }
            }
        }     
    }
}