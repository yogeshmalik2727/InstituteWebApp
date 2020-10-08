using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InstituteWebApp.BusinessLayer;
using InstituteWebApp.Data;

namespace InstituteWebApp.StudentCourses
{
    public class EditModel : PageModel
    {
        private readonly InstituteWebApp.Data.InstituteDataContext _context;

        public EditModel(InstituteWebApp.Data.InstituteDataContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseName");
           ViewData["StudentID"] = new SelectList(_context.Students, "StudentID", "StudentName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StudentCourse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentCourseExists(StudentCourse.StudentCourseID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudentCourseExists(int id)
        {
            return _context.StudentCourses.Any(e => e.StudentCourseID == id);
        }
    }
}
