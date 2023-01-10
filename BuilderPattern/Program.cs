using BuilderPattern.Services.Implementations;

var ticket = new TicketBuilder()
            .BuildDetail("n56tr5", "pn-681s", DateTime.Now.AddDays(5))
            .BuildDeparture(city => city.BuildDetail("LO", "London"))
            .BuildArrival(city => city.BuildDetail("LP", "Liverpool"))
            .BuildStops(stops => stops.BuildDetail("toilets, left-luggage, lost-and-found ,luggage carts, waiting rooms, taxi ranks", DateTime.Now.AddDays(5), DateTime.Now.AddDays(5).AddHours(2))
                                      .BuildDepartureCity(city => city.BuildDetail("LO", "London"))
                                      .BuildArrivalCity(city => city.BuildDetail("BM", "Birmingham")))
            .BuildStops(stops => stops.BuildDetail("toilets, lost-and-found , taxi ranks", DateTime.Now.AddDays(5).AddHours(5), DateTime.Now.AddDays(5).AddHours(7))
                                      .BuildDepartureCity(city => city.BuildDetail("BM", "Birmingham"))
                                      .BuildArrivalCity(city => city.BuildDetail("LP", "Liverpool")))
            .Build();

ticket.TicketInfo();
Console.ReadKey();
