using BuilderPattern.Builders;
using BuilderPattern.Entities;

namespace BuilderPattern.Services
{
    public interface ITicketBuilder
    {
        ITicketBuilder BuildDetail(string ticketNumber, string ticketPnr, DateTime goDate);
        ITicketBuilder BuildType();
        ITicketBuilder BuildStops(Action<ILegBuilder> builder);
        ITicketBuilder BuildDeparture(string departure);
        ITicketBuilder BuildArrival(string arrival);
        Ticket Build();
    }
}
