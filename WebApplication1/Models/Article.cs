﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public bool Published { get; set; }
        public bool IsFavorite { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }



    }
}
