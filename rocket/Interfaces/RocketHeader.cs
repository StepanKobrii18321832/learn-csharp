namespace RocketProgramm
{

    public interface RocketHeader
    {
        int Human { get; }
        int Weight { get; }
        string Type { get; }
        void Message(string text);
        string Name { get; }
        Coordinates Space { get; set; }
    }
}