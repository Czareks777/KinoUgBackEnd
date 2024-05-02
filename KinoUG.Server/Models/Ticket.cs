﻿using System.ComponentModel.DataAnnotations.Schema;

namespace KinoUG.Server.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get;set; }
        [ForeignKey("SeatId")]
        public int Seat { get; set; }
        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public int Price { get; } = 20;
        public User User { get; set; }
    }
}
