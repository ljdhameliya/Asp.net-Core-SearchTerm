using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspnetCoreSearchTerm.Models;

namespace AspnetCoreSearchTerm.Pages.SearchTerms
{
    public class EditModel : PageModel
    {
        private readonly AspnetCoreSearchTerm.Models.AspnetCoreSearchTermContext _context;

        public EditModel(AspnetCoreSearchTerm.Models.AspnetCoreSearchTermContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SearchTerm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SearchTermExists(SearchTerm.ID))
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

        private bool SearchTermExists(int id)
        {
            return _context.SearchTerm.Any(e => e.ID == id);
        }
    }
}
