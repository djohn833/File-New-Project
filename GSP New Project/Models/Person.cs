using System;
using System.ComponentModel.DataAnnotations;

namespace GSPNewProject.Models
{
    public class Person
    {
        public int Id { get; set; }

        
        public DateTime DateAdded { get; set; }

        [Required]
        [StringLength(50,MinimumLength = 5,ErrorMessage = "The Name field must be at least 5 characters long and no more than 50")]
        public string Name { get; set; }

        [Range(0, 120)]
        public int Age { get; set; }

        [Display(Name = "Birth Day")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }
    }
}