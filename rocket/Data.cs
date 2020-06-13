namespace RocketProgramm
{
    static class Data
    {
        public static Command[] CommandList = {
            new FirstCommand(),
            new qCommand(),
            new NewRocketCommand()
        };

        public static Rocket[] RocketList = {
            new Rocket(),
            new Rocket()
        };
    }
}