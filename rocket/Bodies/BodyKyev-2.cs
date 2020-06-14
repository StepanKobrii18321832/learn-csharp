namespace RocketProgramm
{
    class BodyKyev2 : RocketBody
    {
        public int Weight { get; private set; }
        public int FuelVolume { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public string Name { get; private set; }
        public BodyKyev2()
        {
            Weight = 2500;
            FuelVolume = 47200;
            Color = "red";
            Material = "steel";
            Manufacturer = "Russia";
            Name = "Kyev-2";
        }
    }
}
