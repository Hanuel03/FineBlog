﻿namespace FineBlog.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public int? Slug { get; set;}
    }
}
