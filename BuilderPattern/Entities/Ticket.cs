namespace BuilderPattern.Entities
{
    public class Ticket
    {
        public string TicketNumber { get; set; }
        public string TicketPnr { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime GoDate { get; set; }
        public City Departure { get; set; }
        public City Arrival { get; set; }
        public List<Leg> Stops { get; set; }


        public void TicketInfo()
        {
            var x = (DateTime.Now - DateTime.Now).TotalMinutes;

            Console.WriteLine($"ticketNumber : {TicketNumber} \n Pnr Code : {TicketPnr} \n CreateDate : {CreateDate} \n Departure time : {GoDate}\n " +
                $"Departure city : {Departure.Name} \n Arrival city : {Arrival.Name}\n\n " +
                $"Details \n" +
                $"Duration stop : {(int)((Stops.LastOrDefault().DepartureDate) - (Stops.FirstOrDefault().ArrivalDate)).TotalMinutes} min in stop {Stops.FirstOrDefault().ArrivalCityDetail.Name} city \n" +
                $"FacilitiesStation : {Stops.FirstOrDefault().FacilitiesStation}");
        }

    }
}
