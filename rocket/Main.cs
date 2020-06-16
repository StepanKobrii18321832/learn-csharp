using System.Threading;

namespace RocketProgramm
{
    partial class RocketProgramm
    {
        
        
        public static void Main()
        {

            Data.RocketList[0].Header = Data.HeaderList[1];
            Data.RocketList[0].Engine = Data.EngineList[1];
            Data.RocketList[0].Body = Data.BodyList[1];

            RocketConsole ConsoleOne = new RocketConsole(Data.CommandList);
            ConsoleOne.Run();
            
        }   
    }
}