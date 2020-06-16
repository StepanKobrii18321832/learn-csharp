namespace RocketProgramm
{
    static class Data
    {
        public static Command[] CommandList = {
            new qCommand(),
            new NewRocketCommand(),
            new RocketListCommand(),
            new LaunchCommand(),
            new RocketInfoCommand(),
            new RocketListInOrbitCommand(),
            new LandingCommand()
        };

        public static Rocket[] RocketList = {
            new Rocket("A150, Kyev-2, HF600")
        };

        public static Rocket[] RocketListInOrbit = {

        };

        public static RocketBody[] BodyList = {
            new BodyKyev(),
            new BodyKyev2(),
            new BodyF1()
        };

        public static RocketEngine[] EngineList = {
            new EngineHF450(),
            new EngineHF600(),
            new EnginePRP4(),
            new EngineRRP4()
        };

        public static RocketHeader[] HeaderList = {
            new HeaderA100(),
            new HeaderA150(),
            new HeaderA190()
        };

        public static void DeleteRocket(Rocket rocket)
        {
            for (int i = 0; i < RocketList.Length; i++)
            {
                if (RocketList[i].Name == rocket.Name) RocketList[i] = null;
            }
            
        }

        public static void DeleteRocketInOrbit(Rocket rocket)
        {
            for (int i = 0; i < RocketListInOrbit.Length; i++)
            {
                if (RocketListInOrbit[i].Name == rocket.Name) RocketListInOrbit[i] = null;
            }
            
        }
    }
}