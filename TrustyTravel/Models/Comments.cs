using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrustyTravel.Models
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? Comment { get; set; }

        [Required]
        [StringLength(5)] 
        public int Rate { get; set; }

        [ForeignKey("Hotels")]
        public int HotelId { get; set; }
        public Hotels? Hotels { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client? Client { get; set; }
    }
}
