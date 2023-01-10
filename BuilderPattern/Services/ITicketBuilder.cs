using BuilderPattern.Entities;

namespace BuilderPattern.Services
{
    public interface ITicketBuilder
    {
        ITicketBuilder BuildDetail(string ticketNumber, string ticketPnr, DateTime goDate);
        ITicketBuilder BuildStops(Action<ILegBuilder> builder);
        ITicketBuilder BuildDeparture(Action<ICityBuilder> builder);
        ITicketBuilder BuildArrival(Action<ICityBuilder> builder);
        Ticket Build();
    }
}
