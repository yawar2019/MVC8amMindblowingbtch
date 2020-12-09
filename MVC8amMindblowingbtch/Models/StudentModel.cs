using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC8amMindblowingbtch.Models
{
    public class StudentModel
    {
        [ScaffoldColumn(false)]
        public int StudId { get; set; }
        [Display(Name ="Student Name")]
        public string StudName { get; set; }
        public int StudFees { get; set; }
        public string StudCourse { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }
        public bool Status  { get; set; }
    }
}