using BuilderPattern.Entities;

namespace BuilderPattern.Services.Implementations
{
    public class CityBuilder : ICityBuilder
    {
        private City _city;
        public CityBuilder()
        {
            _city = new City();
        }

        public ICityBuilder BuildDetail(string code, string name)
        {
            _city.Code = code;
            _city.Name = name;

            return this;
        }

        public City Build() => _city;
    }
}
