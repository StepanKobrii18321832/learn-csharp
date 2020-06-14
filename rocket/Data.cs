namespace RocketProgramm
{
    static class Data
    {
        public static Command[] CommandList = {
            new FirstCommand(),
            new qCommand(),
            new NewRocketCommand(),
            new RocketListCommand(),
            new LaunchCommand()
        };

        public static Rocket[] RocketList = {
            new Rocket("A100, Kyev, HF450"),
            new Rocket("A150, Kyev-2, HF600")
        };

        public static RocketBody[] BodyList = {
            new BodyKyev(),
            new BodyKyev2()
        };

        public static RocketEngine[] EngineList = {
            new EngineHF450(),
            new EngineHF600()
        };

        public static RocketHeader[] HeaderList = {
            new HeaderA100(),
            new HeaderA150()
        };
    }
}