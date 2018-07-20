using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspnetCoreSearchTerm.Models;

namespace AspnetCoreSearchTerm.Pages.SearchTerms
{
    public class DetailsModel : PageModel
    {
        private readonly AspnetCoreSearchTerm.Models.AspnetCoreSearchTermContext _context;

        public DetailsModel(AspnetCoreSearchTerm.Models.AspnetCoreSearchTermContext context)
        {
            _context = context;
        }

        public SearchTerm SearchTerm { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SearchTerm = await _context.SearchTerm.FirstOrDefaultAsync(m => m.ID == id);

            if (SearchTerm == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
