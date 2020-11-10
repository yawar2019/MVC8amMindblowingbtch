using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC8amMindblowingbtch.Models
{
    public class StudentModel
    {
        public int StudId { get; set; }
        public string StudName { get; set; }
        public int StudFees { get; set; }
        public string StudCourse { get; set; }
        public int DeptId { get; set; }
    }
}