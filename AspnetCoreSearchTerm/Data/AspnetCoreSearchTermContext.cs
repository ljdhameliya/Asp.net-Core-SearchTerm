using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreSearchTerm.Models
{
    public class AspnetCoreSearchTermContext : DbContext
    {
        public AspnetCoreSearchTermContext (DbContextOptions<AspnetCoreSearchTermContext> options)
            : base(options)

        {
        }

        public DbSet<AspnetCoreSearchTerm.Models.SearchTerm> SearchTerm { get; set; }
    }
}
