using BuilderPattern.Entities;

namespace BuilderPattern.Services
{
    public interface ICityBuilder
    {
        ICityBuilder BuildDetail(string code, string name);
        City Build();
    }
}
