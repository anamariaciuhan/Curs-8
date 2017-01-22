using lab9.Custom_Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace lab9.Models
{
    [Bind(Exclude = "Country")] // exercitiul 2 mvc curs 9
    //[Bind(Include = "all the other properties")]
    public class ProjectEvaluation : IValidatableObject
    {
        [MaxWordsAttribute(3)]
        public string name { get; set; }

        [Required]
        [StringLength(1000)]
        [MinWordsAttribute(2)]
        public string city { get; set; }

        public string country { get; set; }

        [Range(1, 10)] // exercitiul 3 mvc curs 9
        [Required]
        public double rating { get; set; }

        public int id { get; set; } // exercitiul 7 mvc curs 8

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (rating < 2 && name.ToLower().StartsWith("john"))
            
                yield return new ValidationResult("Sorry John, you can't do this");

            }
            public IEnumerable<ValidationResult> Validare(ValidationContext validationContext)
        {
            if (rating > 8 && name.ToLower().StartsWith("anam"))
                yield return new ValidationResult("A very good rating !");
        }
    }
}

 

