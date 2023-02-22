using Mission06_cjwalch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required(ErrorMessage = "Hey fool! Every movie needs a title!")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Need to enter the Year.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Need to Enter the Director.")]
        public string Director { get; set; }

        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        // foreign key relationship
        [Required(ErrorMessage = "Need to enter the Category.")]
        public int CategoryId { get; set; } // foreign key
        public Category Category { get; set; } // instance of object

        [Required(ErrorMessage = "Need to enter the Rating.")]
        public string Rating { get; set; }

    }
}
