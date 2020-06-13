namespace RocketProgramm
{
    class BodyKyev : RocketBody
    {
        public int Weight { get; private set; }
        public int FuelVolume { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public BodyKyev()
        {
            Weight = 4000;
            FuelVolume = 50000;
            Color = "red";
            Material = "steel";
            Manufacturer = "Russia";
        }
    }
}
