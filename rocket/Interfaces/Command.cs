namespace RocketProgramm
{
    public abstract class Command
    {
        public abstract string Name { get; }
        public abstract void Execute(Location location);

        public bool Contains(string UserCommand, Location CurrentLocation)
        {
            if (UserCommand == Name)
            {
                Execute(CurrentLocation);
                return true;
            } 
            return false;
        }
    }
}