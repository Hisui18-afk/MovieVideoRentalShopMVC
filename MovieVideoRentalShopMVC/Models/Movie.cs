﻿using System.ComponentModel.DataAnnotations;

namespace MovieVideoRentalShopMVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
