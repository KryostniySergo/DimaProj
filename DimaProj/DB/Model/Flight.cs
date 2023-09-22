namespace DimaProj.DB.Model
{
    public class Flight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FlyTime { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public List<Passenger> Passengers { get; set; } = new();
    }
}
