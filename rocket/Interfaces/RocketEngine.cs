namespace RocketProgramm
{
    interface RocketEngine
    {
        void Start();
        void End();
        int Weight { get; }
        int Power { get; }
        int FuelConsumption { get; }
    }
}