﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactForm_Andy.Shared.Models
{
    public class ContactForm
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Message { get; set; }
    }
}
