namespace RocketProgramm
{
    class Location
    {
        public Coordinates NameLocation;

        public Rocket[] RocketList = {};

        public Rocket[] RocketListInOrbit = {};

        public Location() 
        {
            NameLocation = new Coordinates();
        }

        public Location(Coordinates input) : this()
        {
            NameLocation = input;
        }

        public Location(Planet planet, int orbitRadius)
        {
            NameLocation = new Coordinates(planet, orbitRadius);
        }
    }
}