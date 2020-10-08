using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InstituteWebApp.BusinessLayer;
using InstituteWebApp.Data;

namespace InstituteWebApp.StudentCourses
{
    public class CreateModel : PageModel
    {
        private readonly InstituteWebApp.Data.InstituteDataContext _context;

        public CreateModel(InstituteWebApp.Data.InstituteDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseName");
        ViewData["StudentID"] = new SelectList(_context.Students, "StudentID", "StudentName");
            return Page();
        }

        [BindProperty]
        public StudentCourse StudentCourse { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.StudentCourses.Add(StudentCourse);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
