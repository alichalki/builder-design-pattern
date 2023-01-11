using BuilderPattern.Entities;

namespace BuilderPattern.Builders
{
    public interface ILegBuilder
    {
        ILegBuilder BuildDetail(string facilitiesStation, DateTime departureDate, DateTime arrivalDate);
        ILegBuilder BuildDepartureCity(string departure);
        ILegBuilder BuildArrivalCity(string arrival);
        Leg Build();
    }
}
