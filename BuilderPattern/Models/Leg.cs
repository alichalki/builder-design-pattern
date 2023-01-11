using BuilderPattern.Common;

namespace BuilderPattern.Entities
{
    public class Leg
    {
        public string FacilitiesStation { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public StationTypeEnume StationType { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
    }
}
