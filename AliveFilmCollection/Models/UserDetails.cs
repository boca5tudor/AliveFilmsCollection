using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AliveFilmCollection.Models
{
    public class UserDetails
    {
        public int ID { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //[Required]
        //[Display(Name = "Date of birth")]
        //public DateTime DateOfBirth { get; set; }

        [Display(Name = "Favourite film")]
        public string FavouriteFilm { get; set; }

        public string UserName { get; set; }

        // [EmailAddress]
        public string Email { get; set; }

        //  [StringLength(10, MinimumLength =2)]
        // [RegularExpression(@"d\{5,10}", ErrorMessage ="The password needs minimum 5 characters")]
        public string Password { get; set; }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        // added for model - DB interaction 
        public virtual ApplicationUser ApplicationUserMine { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }
        public virtual ICollection<UserFilms> UserFilms { get; set; }
    }
}