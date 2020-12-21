using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC8amMindblowingbtch.Models
{
    public class Register
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage ="Employee Name Cannot be Empty ")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty ")]

        public string Password { get; set; }
       [Compare("Password",ErrorMessage ="Password and Confirm Password is not Matching")]
        public string ConfirmPwd { get; set; }
        [Range(18,40,ErrorMessage ="18 to 40 Only allowed")]
        public int age { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Email Id is Not Valid ")]
        public string EmailId { get; set; }
        [StringLength(18, ErrorMessage = "Only 18 Characters Allowed")]
        public string Address { get; set; }

    }
}