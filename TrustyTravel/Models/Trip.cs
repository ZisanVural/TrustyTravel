﻿using System.ComponentModel.DataAnnotations;

namespace TrustyTravel.Models
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

    }
}
