using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InstituteWebApp.BusinessLayer;
using InstituteWebApp.Data;

namespace InstituteWebApp.Branches
{
    public class DeleteModel : PageModel
    {
        private readonly InstituteWebApp.Data.InstituteDataContext _context;

        public DeleteModel(InstituteWebApp.Data.InstituteDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Branch Branch { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Branch = await _context.Branches.FirstOrDefaultAsync(m => m.BranchID == id);

            if (Branch == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Branch = await _context.Branches.FindAsync(id);

            if (Branch != null)
            {
                _context.Branches.Remove(Branch);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
