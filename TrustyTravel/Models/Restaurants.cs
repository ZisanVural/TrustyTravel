using System.ComponentModel.DataAnnotations;

namespace TrustyTravel.Models
{
    public class Restaurants
    {
        [Key]
        public int Id { get; set; }
        public string? RestaurantName { get; set; }

        [Required]
        [StringLength(5)]
        public int Rate { get; set; }
        public string? Location { get; set; }
        public string? Comments { get; set; }
    }
}
