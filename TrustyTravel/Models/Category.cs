using System.ComponentModel.DataAnnotations;

namespace TrustyTravel.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Keywords { get; set; }
        public string? Description { get; set; }
    }
}
