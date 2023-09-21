using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    
    public class Instructor
    {
        public int InstructorID { get; set; }
        [StringLength(50)]
        public string Name { get; set;}
        [StringLength(50)]
        public string Surname { get; set;}
        public string Image { get; set;}
        public List<Course> Courses { get; set;}
    }
}