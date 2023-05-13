using System;
using System.ComponentModel.DataAnnotations;

namespace Vtnorton.Model
{
    public class Emails
    {
	public int ListID { get; set; }
        [Required(ErrorMessage = "Your E-mail is required")]
        [EmailAddress (ErrorMessage = "Please, input a valid e-mail address")]
        public string Email { get; set; }

        public string LikedingProfile { get; set; }
        public string TwitterProfile { get; set; }
        public string FacebookProfile { get; set; }
        public string Observation { get; set; }

        [MinLength(2, ErrorMessage = "The First Name field must contain at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "The First Name field cannot contain more than 50 characters.")]
        public string FirstName { get; set; }

        [MinLength(2, ErrorMessage = "The Last Name field must contain at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "The Last Name field cannot contain more than 50 characters.")]
        public string LastName { get; set; }

        public string JavaScriptToRun { get; set; }
    }
}
