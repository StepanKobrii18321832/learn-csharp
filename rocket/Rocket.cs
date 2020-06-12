namespace RocketProgramm
{
    class Rocket
    {
        public RocketHeader Header { get; set; }
        public RocketEngine Engine { get; set; }
        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight;
            }
        }
    }
}