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
    public class IndexModel : PageModel
    {
        private readonly InstituteWebApp.Data.InstituteDataContext _context;

        public IndexModel(InstituteWebApp.Data.InstituteDataContext context)
        {
            _context = context;
        }

        public IList<Branch> Branch { get;set; }

        public async Task OnGetAsync()
        {
            Branch = await _context.Branches.ToListAsync();
        }
    }
}
