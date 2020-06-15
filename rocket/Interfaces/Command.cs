namespace RocketProgramm
{
    public abstract class Command
    {
        public abstract string Name { get; }
        public abstract void Execute();

        public bool Contains(string UserCommand)
        {
            if (UserCommand == Name)
            {
                Execute();
                return true;
            } 
            return false;
        }
    }
}