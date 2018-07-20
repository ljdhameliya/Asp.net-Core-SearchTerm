using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspnetCoreSearchTerm.Models;

namespace AspnetCoreSearchTerm.Pages.SearchTerms
{
    public class CreateModel : PageModel
    {
        private readonly AspnetCoreSearchTerm.Models.AspnetCoreSearchTermContext _context;

        public CreateModel(AspnetCoreSearchTerm.Models.AspnetCoreSearchTermContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SearchTerm SearchTerm { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SearchTerm.Add(SearchTerm);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}