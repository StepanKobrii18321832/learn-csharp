namespace RocketProgramm
{
    class BodyL1 : RocketBody
    {
        public int Weight { get; private set; }
        public int FuelVolume { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public string Name { get; private set; }
        public BodyL1()
        {
            Weight = 2500;
            FuelVolume = 48300;
            Color = "red";
            Material = "steel";
            Manufacturer = "Russia";
            Name = "L-1";
        }
    }
}
