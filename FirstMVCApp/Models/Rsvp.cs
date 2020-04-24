using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    /// <summary>
    /// Domain model for Rsvp
    /// </summary>
    public class Rsvp
    {
        public string Namei { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Attending { get; set; }
    }

    public class CreateRsvpRequest
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Attending { get; set; }
    }

    public class CreateRsvpViewModel : IValidatableObject
    {
        [Required(ErrorMessage = "გთხოვთ შეავსოთ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "გთხოვთ შეავსოთ")]
        public string Email { get; set; }

        public string Password { get; set; }

        public bool Attending { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Email == "archil@wandio.com")
            {
                yield return new ValidationResult("you shall not pass", new List<string> { "email" });
            }
        }
    }
}
