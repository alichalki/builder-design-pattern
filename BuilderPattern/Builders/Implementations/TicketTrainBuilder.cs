using BuilderPattern.Builders;
using BuilderPattern.Entities;
using System.Reflection.PortableExecutable;

namespace BuilderPattern.Services.Implementations
{
    public class TicketTrainBuilder : ITicketBuilder
    {
        private Ticket _ticket;
        public TicketTrainBuilder()
        {
            _ticket = new Ticket();
            _ticket.Stops = new List<Leg>();
        }

        public ITicketBuilder BuildDeparture(string departure)
        {
            _ticket.Departure = departure;

            return this;
        }

        public ITicketBuilder BuildArrival(string arrival)
        {
            _ticket.Arrival = arrival;

            return this;
        }

        public ITicketBuilder BuildDetail(string ticketNumber, string ticketPnr, DateTime goDate)
        {
            _ticket.TicketNumber = ticketNumber;
            _ticket.TicketPnr = ticketPnr;
            _ticket.CreateDate = DateTime.Now;
            _ticket.GoDate = goDate;

            return this;
        }


        public ITicketBuilder BuildStops(Action<ILegBuilder> builder)
        {
            var legBuilder = new LegTrainBuilder();
            builder(legBuilder);

            _ticket.Stops.Add(legBuilder.Build());

            return this;
        }
        public ITicketBuilder BuildType()
        {
            _ticket.IsFlightTicket = false;
            _ticket.IsTrainTicket = true;
            _ticket.TransportationType = Common.StationTypeEnume.Train;

            return this;
        }


        public Ticket Build() => _ticket;

    }
}
