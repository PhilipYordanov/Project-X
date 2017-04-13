﻿using Eventis.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventis.Models
{
    public class Event
    {
        private const int ContentMinimumLength = 5;

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100
            , ErrorMessage = "Title cannot be less than 5 symbols and more than 100 symbols"
            , MinimumLength = ContentMinimumLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(100
            , MinimumLength = ContentMinimumLength
            , ErrorMessage = "Content cannot be less than 5 characters long")]
        public string Content { get; set; }

        public string ImagePath { get; set; }

        public int ViewCount { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual ApplicationUser Author { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public virtual ICollection<Contact> Contact { get; set; }

        public Genre Genre { get; set; }
    }
}