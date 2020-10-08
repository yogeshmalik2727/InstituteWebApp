using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstituteWebApp.BusinessLayer
{
    public class StudentCourse
    {
        
        public int StudentCourseID { get; set; }

        public int CourseID { get; set; }

        public Course Course { get; set; }

        public int StudentID { get; set; }

        public Student Student { get; set; }

        public float Fee { get; set; }


    }
}
