using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an individual Student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The unique identifier for the student
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// The student's first and last name of student
        /// </summary>
        [Display(Name="Full Name:")]
        [Required(ErrorMessage = "Full Name is required!")]
        public string FullName { get; set; }

        /// <summary>
        /// The day the student was born. Time is ignored
        /// </summary>
        [Display(Name="Date of Birth:")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The student email (ends with @student.cptc.edu)
        /// </summary>
        [Display(Name="Email Address:")]
        [EmailAddress]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Primary phone number
        /// </summary>
        [Display(Name="Phone Number:")]
        [Required]
        public string PhoneNumber { get; set; }
    }
}
