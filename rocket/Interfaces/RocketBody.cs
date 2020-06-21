namespace RocketProgramm
{
    public interface RocketBody
    {
        int Weight { get; }
        int FuelVolume { get; }
        string Name { get; }
    }
}