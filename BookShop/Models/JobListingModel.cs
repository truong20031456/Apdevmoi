<<<<<<< HEAD
﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
>>>>>>> a5d40dac69ad7c2a6688862db1c94f0182431905
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BookShop.Models
{
    public class JobListingModel
    {
        [Key]
        public int JobListingId { get; set; }
<<<<<<< HEAD

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime ApplicationDeadline { get; set; }

=======
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime ApplicationDeadline { get; set; }
>>>>>>> a5d40dac69ad7c2a6688862db1c94f0182431905
        [Required]
        public string? Location { get; set; }

        public int CategoryId { get; set; }
<<<<<<< HEAD

        [ForeignKey(nameof(CategoryId))]
        [ValidateNever]
        public Category? Category { get; set; }

        // Navigation property to reference the employer (IdentityUser)
        public ApplicationModel? Employer { get; set; }

        // Property to accept image file
        [NotMapped] // Exclude this property from the database schema
        [Display(Name = "Image")] // Display name for the input field
        [Required(ErrorMessage = "Please select an image.")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }

        // Optional property to store the image path or byte array in the database
        public string? ImagePath { get; set; }
        public bool ImageUploaded { get; set; }
=======
        [ForeignKey(nameof(CategoryId))]
        [ValidateNever]
        public  Category? Category { get; set; }

        // Navigation property to reference the employer (IdentityUser)
        public ApplicationModel? Employer { get; set; }
        public string? Image { get; set; }
>>>>>>> a5d40dac69ad7c2a6688862db1c94f0182431905
    }
}
