using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AliveFilmCollection.Models
{
    public class UserFilms
    {
        public int ID { get; set; }


        [Required]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Release Year")]
        public string ReleaseYear { get; set; }

        [Required]
        public string Genre { get; set; }

      //  [Column(TypeName = "varchar")]
       // [RegularExpression(@"d\{2,10}", ErrorMessage = "Give it a rating between 1-10")]
       // [Required]
        public int Rating { get; set; }
        public string TypeOfMedia { get; set; }
        public string Comments { get; set; }
        public decimal Price { get; set; }

        public int UserFilmsId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual UserDetails UserDetails { get; set; }

    }
}