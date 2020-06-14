using System.Threading;

namespace RocketProgramm
{
    partial class RocketProgramm
    {
        
        
        public static void Main()
        {
            
            Data.RocketList[0].Header = Data.HeaderList[0]; //new HeaderA100();
            Data.RocketList[0].Engine = Data.EngineList[0]; //new EngineHF450();
            Data.RocketList[0].Body = Data.BodyList[0]; //new BodyKyev2();

            Data.RocketList[1].Header = Data.HeaderList[1];
            Data.RocketList[1].Engine = Data.EngineList[1];
            Data.RocketList[1].Body = Data.BodyList[1];

            RocketConsole ConsoleOne = new RocketConsole(Data.CommandList);
            ConsoleOne.Run();
            
        }   
    }
}