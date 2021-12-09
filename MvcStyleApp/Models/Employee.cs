using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MvcStyleApp.Models
{
    public class Employee
    {
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Employee FirstName minimum 5 chars and max 20")]
        public string EmployeeFirstName { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Employee LastName minimum 5 chars and max 20")]
        public string EmployeeLastName { get; set; }
        [Range(20, 30, ErrorMessage = "Age b/w 20 to 30")]
        public string Age{ get; set; }
        [Required(ErrorMessage = "Age must be given")]
        public string Gender { get; set; }
        
        [Required(ErrorMessage = "Gender must be selected")]

        public string Address { get; set; }
        [Required(ErrorMessage = "Address must be given")]


        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "phone number must be given")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Email Id must be given")]
        public string State { get; set; }
    }
}
