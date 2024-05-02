﻿namespace KinoUG.Server.Models
{
    public class Movie
    {
        public int MovieId { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
