using System;
using System.ComponentModel.DataAnnotations;

namespace ChatApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        [Required]
        public string Text { get; set; }   
        public DateTime DateCreated { get; set; }
        public AppUser AppUser { get; set; }
    }
}