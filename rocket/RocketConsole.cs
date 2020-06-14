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
                    for (int i = 0; i < List.Length; i++)
                    {
                        List[i].Contains(str);
                    }
                }
            }
        }     
    }
}