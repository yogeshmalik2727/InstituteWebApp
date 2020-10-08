using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InstituteWebApp.BusinessLayer;
using InstituteWebApp.Data;

namespace InstituteWebApp.StudentCourses
{
    public class DetailsModel : PageModel
    {
        private readonly InstituteWebApp.Data.InstituteDataContext _context;

        public DetailsModel(InstituteWebApp.Data.InstituteDataContext context)
        {
            _context = context;
        }

        public StudentCourse StudentCourse { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudentCourse = await _context.StudentCourses
                .Include(s => s.Course)
                .Include(s => s.Student).FirstOrDefaultAsync(m => m.StudentCourseID == id);

            if (StudentCourse == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
