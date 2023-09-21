using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearningProject.DAL.Entities
{
    public class Category

    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set;}
      
        
    }
}