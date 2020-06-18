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
            Data.RocketList[0].Header.Space = new Coordinates();

            Data.RocketList[1].Header = Data.HeaderList[3];
            Data.RocketList[1].Engine = Data.EngineList[3];
            Data.RocketList[1].Body = Data.BodyList[2];
            Data.RocketList[1].Header.Space = new Coordinates();

            RocketConsole ConsoleOne = new RocketConsole(Data.CommandList);
            ConsoleOne.Run();
            
        }   
    }
}