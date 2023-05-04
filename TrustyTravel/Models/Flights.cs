using System.ComponentModel.DataAnnotations;

namespace TrustyTravel.Models
{
    public class Flights
    {
        [Key]
        public int Id { get; set; }
        public string? FlightName { get; set; }
        public string? FlightDate { get; set; }
        public string? Destination { get; set; }
        public int TicketPrice { get; set; }
    }
}
