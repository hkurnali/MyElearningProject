using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Course

    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public string ImageURL { get; set; }
        public int CategoryID { get; set; }
        
        public Category Category { get; set; }
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
    }
}