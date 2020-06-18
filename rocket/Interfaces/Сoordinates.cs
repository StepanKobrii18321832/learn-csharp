namespace RocketProgramm
{
    class Coordinates
    {
        public int OrbitRadius { get; set; } 
        public Planet Object { get; set; }
        public Coordinates()
        {
            OrbitRadius = 0;
            Object = Planet.Earth;
        }
    }    
}