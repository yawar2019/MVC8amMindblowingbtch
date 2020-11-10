using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC8amMindblowingbtch.Models
{
    public class StudentDept
    {
      public List<StudentModel> students { get; set; }
      public List<DepartmentModel>departments { get; set; }
    }
}