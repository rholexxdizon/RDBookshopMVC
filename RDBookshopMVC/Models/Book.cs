﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace RDBookshopMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }

        //Foreign Keys
        [Display(Name = "Author")]
        [Required]
        public int AuthorId { get; set; }
        [ValidateNever]
        public Author Author { get; set; }

        [Display(Name = "Category")]
        [Required]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }

        // URL to a book cover image
        public string CoverImageUrl { get; set; }
    }
}
