namespace RocketProgramm
{

    interface RocketHeader
    {
        int Human { get; }
        int Weight { get; }
        string Type { get; }
        void Message(string text);
        string Name { get; }
    }
}