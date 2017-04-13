﻿using Eventis.Models.Identity;
using System.ComponentModel.DataAnnotations;

namespace Eventis.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200
            , ErrorMessage = "Comment cannot be longer than 200 symbols"
            , MinimumLength = 3)]
        public string Content { get; set; }

        [Required]
        public Event Event { get; set; }

        [Required]
        public ApplicationUser Author { get; set; }
    }
}