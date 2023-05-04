using System.ComponentModel.DataAnnotations;

namespace TrustyTravel.Models
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }

        public string? Question { get; set; }

        public string? Answer { get; set; }
    }
}
