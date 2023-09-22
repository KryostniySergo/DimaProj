namespace DimaProj.DB.Model
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }

        public int FlightId { get; set; }
        public Flight? Flight { get; set; }
    }
}
