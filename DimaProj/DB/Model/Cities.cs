namespace DimaProj.DB.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Flight> Flights { get; set; }
    }
}
