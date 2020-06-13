using System;
using System.Threading;

namespace RocketProgramm
{
    partial class RocketProgramm
    {
        public static void Main()
        {
            Console.WriteLine("(owo)");
            Command[] CommandList = {
                new FirstCommand(),
                new qCommand()
            };

            while(true)
            {
                Console.Write("> ");
                string str = Console.ReadLine();
                for (int i = 0; i < CommandList.Length; i++)
                {
                    CommandList[i].Contains(str);
                }
            }
            
            
            
        }        
    }
}