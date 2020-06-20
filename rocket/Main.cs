using System.Threading;

namespace RocketProgramm
{
    partial class RocketProgramm
    {
        
        
        public static void Main()
        {

            AddRocketlist(EarthLocation.RocketList, new Rocket("Main"));
            AddRocketlist(EarthLocation.RocketList, new Rocket("Second"));

            Data.EarthLocation.RocketList[0].Header = Data.HeaderList[1];
            Data.EarthLocation.RocketList[0].Engine = Data.EngineList[1];
            Data.EarthLocation.RocketList[0].Body = Data.BodyList[1];
            Data.EarthLocation.RocketList[0].Header.Space = new Coordinates();

            Data.EarthLocation.RocketList[1].Header = Data.HeaderList[3];
            Data.EarthLocation.RocketList[1].Engine = Data.EngineList[3];
            Data.EarthLocation.RocketList[1].Body = Data.BodyList[2];
            Data.EarthLocation.RocketList[1].Header.Space = new Coordinates();

            RocketConsole ConsoleOne = new RocketConsole(Data.CommandList);
            ConsoleOne.Run();
            
        }   
    }
}