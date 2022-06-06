using System;
using System.Collections.Generic;

namespace iSchoolWebApp.Models
{
    public class Course
    {
        public string courseID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class CourseRootModel
    {
        public List<Course> course { get; set; }
        public String Title  {get; set;}
        
    }

}
