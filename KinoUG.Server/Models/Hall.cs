﻿namespace KinoUG.Server.Models
{
    public class Hall
    {
        public int Id { get; set; } 
        public ICollection<Seat> Seats { get; set;}
        
    }
}
