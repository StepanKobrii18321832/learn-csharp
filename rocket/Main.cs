using System.Threading;

namespace RocketProgramm
{
    partial class RocketProgramm
    {
        
        
        public static void Main()
        {

            Data.AddRocketList(ref Data.LocationList[0].RocketList, new Rocket("Main"));
            Data.AddRocketList(ref Data.LocationList[0].RocketList, new Rocket("Second"));

            Data.LocationList[0].RocketList[0].Header = Data.HeaderList[1];
            Data.LocationList[0].RocketList[0].Engine = Data.EngineList[1];
            Data.LocationList[0].RocketList[0].Body = Data.BodyList[1];
            Data.LocationList[0].RocketList[0].Header.Space = new Coordinates();

            Data.LocationList[0].RocketList[1].Header = Data.HeaderList[4];
            Data.LocationList[0].RocketList[1].Engine = Data.EngineList[6];
            Data.LocationList[0].RocketList[1].Body = Data.BodyList[3];
            Data.LocationList[0].RocketList[1].Header.Space = new Coordinates();

            RocketConsole ConsoleOne = new RocketConsole(Data.CommandList);
            ConsoleOne.Run();
            
        }   
    }
}