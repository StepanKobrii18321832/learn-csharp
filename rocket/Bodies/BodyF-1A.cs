namespace RocketProgramm
{
    class BodyF1A : RocketBody
    {
        public int Weight { get; private set; }
        public int FuelVolume { get; private set; }
        public string Color { get; private set; }
        public string Material { get; private set; }
        public string Manufacturer { get; private set; }
        public string Name { get; private set; }
        public BodyF1A()
        {
            Weight = 8000;
            FuelVolume = 100500;
            Color = "red";
            Material = "steel";
            Manufacturer = "Russia";
            Name = "F-1A";
        }
    }
}
