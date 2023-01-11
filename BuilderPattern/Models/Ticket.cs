using BuilderPattern.Common;

namespace BuilderPattern.Entities
{
    public class Ticket
    {
        public string TicketNumber { get; set; }
        public string TicketPnr { get; set; }
        public StationTypeEnume TransportationType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime GoDate { get; set; }
        public bool IsFlightTicket { get; set; }
        public bool IsTrainTicket { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public List<Leg> Stops { get; set; }


        public void TicketInfo()
        {
            var x = (DateTime.Now - DateTime.Now).TotalMinutes;

            Console.WriteLine(
                $"you purchase {TransportationType} ticket from {Departure} to {Arrival} \n " +
                $"{TransportationType} ticket detail \n\n " +
                $"ticketNumber : {TicketNumber} \n Pnr Code : {TicketPnr} \n CreateDate : {CreateDate} \n Departure time : {GoDate}\n " +
                $"Departure city : {Departure} \n Arrival city : {Arrival}\n\n " +
                $"Details \n" +
                $"Duration stop : {(int)((Stops.LastOrDefault().DepartureDate) - (Stops.FirstOrDefault().ArrivalDate)).TotalMinutes} min in stop {Stops.FirstOrDefault().Arrival} city \n" +
                $"FacilitiesStation : {Stops.FirstOrDefault().FacilitiesStation}");
        }

    }
}
