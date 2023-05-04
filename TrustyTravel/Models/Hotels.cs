using System.ComponentModel.DataAnnotations;

namespace TrustyTravel.Models
{
    public class Hotels
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }

        [Required] //not null
        [StringLength(50)]
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Required]
        [StringLength(5)]
        public int Rate { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Fax { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Location { get; set; }
        public string? Keywords { get; set; }

        public Category? Category { get; set; }
        
    
    }

}
