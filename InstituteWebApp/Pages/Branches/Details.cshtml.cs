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
    public class DetailsModel : PageModel
    {
        private readonly InstituteWebApp.Data.InstituteDataContext _context;

        public DetailsModel(InstituteWebApp.Data.InstituteDataContext context)
        {
            _context = context;
        }

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
    }
}
