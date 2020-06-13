using System.Threading;

namespace RocketProgramm
{
    partial class RocketProgramm
    {
        
        
        public static void Main()
        {
            
            Data.RocketList[0].Header = new HeaderA100();
            Data.RocketList[0].Engine = new EngineHF450();
            Data.RocketList[0].Body = new BodyKyev2();

            Data.RocketList[1].Header = new HeaderA150();
            Data.RocketList[1].Engine = new EngineHF600();
            Data.RocketList[1].Body = new BodyKyev();

            RocketConsole ConsoleOne = new RocketConsole(Data.CommandList);
            ConsoleOne.Run();
            
        }   
    }
}