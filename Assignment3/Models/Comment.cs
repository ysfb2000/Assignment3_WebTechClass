﻿namespace Assignment3.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }

}
