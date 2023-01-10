using BuilderPattern.Entities;
using System.Xml.Linq;

namespace BuilderPattern.Services.Implementations
{
    public class LegBuilder : ILegBuilder
    {
        private Leg _leg;
        public LegBuilder()
        {
            _leg = new Leg();
        }


        public ILegBuilder BuildDetail(string facilitiesStation, DateTime departureDate, DateTime arrivalDate)
        {
            _leg.FacilitiesStation = facilitiesStation;
            _leg.DepartureDate = departureDate;
            _leg.ArrivalDate = arrivalDate;

            return this;
        }

        public ILegBuilder BuildDepartureCity(Action<ICityBuilder> builder)
        {
            var cityBuilder = new CityBuilder();
            builder(cityBuilder);
            _leg.DepartureCityDetail = cityBuilder.Build();

            return this;
        }

        public ILegBuilder BuildArrivalCity(Action<ICityBuilder> builder)
        {
            var cityBuilder = new CityBuilder();
            builder(cityBuilder);
            _leg.ArrivalCityDetail = cityBuilder.Build();

            return this;
        }


        public Leg Build() => _leg;
    }
}
