namespace RocketProgramm
{
    public abstract class Command
    {
        public abstract string Name { get; }
        public abstract void Execute();

        public void Contains(string UserCommand)
        {
            if (UserCommand == Name)
            {
                Execute();
            } 
        }
    }
}