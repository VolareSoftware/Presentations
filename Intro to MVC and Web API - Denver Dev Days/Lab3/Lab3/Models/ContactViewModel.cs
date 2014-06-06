using System;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class ContactViewModel
    {
        // Lab #3, Step #4
        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(50, ErrorMessage = "Please enter a first name less than 50 characters.")]
        public string FirstName { get; set; }

        // Lab #3, Step #4
        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(50, ErrorMessage = "Please enter a last name less than 50 characters.")]
        public string LastName { get; set; }

        // Lab #3, Step #4
        [Required(ErrorMessage = "Please enter a phone number.")]
        [StringLength(15, ErrorMessage = "Please enter a phone number less than 15 characters.")]
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Please enter a valid phone number format (###-###-####).")]
        public string Phone { get; set; }

        // Lab #3, Step #4
        [Required(ErrorMessage = "Please enter an email address.")]
        [StringLength(100, ErrorMessage = "Please enter an email address less than 100 characters.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Please enter a valid email format (myname@mydomain.com).")]
        public string Email { get; set; }

        public void Save()
        {
            // Could save to DB, send emails, etc.
            // But for demos, doesn't really do anythin
        }
    }
}
