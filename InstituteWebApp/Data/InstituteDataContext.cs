using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstituteWebApp.BusinessLayer;

namespace InstituteWebApp.Data
{
    public class InstituteDataContext:DbContext
    {
        public InstituteDataContext(DbContextOptions<InstituteDataContext> options):base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<Branch> Branches { get; set; }

    }
}
