using BuilderPattern.Services.Implementations;

var ticket = new TicketFlightBuilder()
            .BuildDetail("n56tr5", "pn-681s", DateTime.Now.AddDays(5))
            .BuildDeparture("London")
            .BuildArrival("Liverpool")
            .BuildStops(stops => stops.BuildDetail("toilets, left-luggage, lost-and-found ,luggage carts, waiting rooms, taxi ranks", DateTime.Now.AddDays(5), DateTime.Now.AddDays(5).AddHours(2))
                                      .BuildDepartureCity("London")
                                      .BuildArrivalCity("Birmingham"))
            .BuildStops(stops => stops.BuildDetail("toilets, lost-and-found , taxi ranks", DateTime.Now.AddDays(5).AddHours(5), DateTime.Now.AddDays(5).AddHours(7))
                                      .BuildDepartureCity("Birmingham")
                                      .BuildArrivalCity("Liverpool"))
            .Build();

ticket.TicketInfo();
Console.ReadKey();
