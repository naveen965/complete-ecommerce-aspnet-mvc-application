﻿using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class Producer
    {
        [Key]

        public int Id { get; set; }
        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
