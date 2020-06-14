namespace RocketProgramm
{

    interface RocketHeader
    {
        int Human { get; }
        int Weight { get; }
        void Message(string text);
        string Name { get; }
    }
}