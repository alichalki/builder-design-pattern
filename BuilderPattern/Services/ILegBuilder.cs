using BuilderPattern.Entities;

namespace BuilderPattern.Services
{
    public interface ILegBuilder
    {
        ILegBuilder BuildDetail(string facilitiesStation, DateTime departureDate, DateTime arrivalDate);
        ILegBuilder BuildDepartureCity(Action<ICityBuilder> builder);
        ILegBuilder BuildArrivalCity(Action<ICityBuilder> builder);
        Leg Build();
    }
}
