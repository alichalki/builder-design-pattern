namespace BuilderPattern.Entities
{
    public class Leg
    {
        public string FacilitiesStation { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public City DepartureCityDetail { get; set; }
        public City ArrivalCityDetail { get; set; }
    }
}
