namespace RocketProgramm
{
    public class Coordinates
    {
        public int OrbitRadius { get; set; } 
        public Planet Object { get; set; }
        public Coordinates()
        {
            OrbitRadius = 0;
            Object = Planet.Earth;
        }

        public Coordinates(Planet planet, int orbitRadius)
        {
            Object = planet;
            OrbitRadius = orbitRadius;
        }
    }    
}