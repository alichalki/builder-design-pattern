using BuilderPattern.Entities;

namespace BuilderPattern.Services.Implementations
{
    public class TicketBuilder : ITicketBuilder
    {
        private Ticket _ticket;
        public TicketBuilder()
        {
            _ticket = new Ticket();
            _ticket.Stops = new List<Leg>();
        }

        public ITicketBuilder BuildDeparture(Action<ICityBuilder> builder)
        {
            var cityBuilder = new CityBuilder();
            builder(cityBuilder);

            _ticket.Departure = cityBuilder.Build();

            return this;
        }

        public ITicketBuilder BuildArrival(Action<ICityBuilder> builder)
        {
            var cityBuilder = new CityBuilder();
            builder(cityBuilder);

            _ticket.Arrival = cityBuilder.Build();

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
            var legBuilder = new LegBuilder();
            builder(legBuilder);

            _ticket.Stops.Add(legBuilder.Build());

            return this;
        }

        
        public Ticket Build() => _ticket;
    }
}
