using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrarySportGroup.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is required", AllowEmptyStrings = false)]
        [Display(Name = "Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Numbers and special characters are not allowed in the name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname is required", AllowEmptyStrings = false)]
        [Display(Name = "Surname")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Numbers and special characters are not allowed in the surname.")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        [Required]
        [RegularExpression(@"^\d{8}(-\d{5})?$", ErrorMessage = "Invalid Zip Code.")]
        public string zipCode { get; set; }
        [StringLength(12, MinimumLength = 9, ErrorMessage = "Invalid Phone Number")]
        [Required(ErrorMessage = "Phone Number is required")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Enter a valid email ...")]
        public string Email { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Identifier too long (11 character limit).")]
        public string Identifier { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Passworld")]
        public string Passworld { get; set; }
    }
}
