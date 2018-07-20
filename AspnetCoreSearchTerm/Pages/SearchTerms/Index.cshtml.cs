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
    public class IndexModel : PageModel
    {
        private readonly AspnetCoreSearchTerm.Models.AspnetCoreSearchTermContext _context;

        public IndexModel(AspnetCoreSearchTerm.Models.AspnetCoreSearchTermContext context)
        {
            _context = context;
        }

        public IList<SearchTerm> SearchTerm { get;set; }

        public async Task OnGetAsync()
        {
            SearchTerm = await _context.SearchTerm.Take(100).ToListAsync();
        }
    }
}
