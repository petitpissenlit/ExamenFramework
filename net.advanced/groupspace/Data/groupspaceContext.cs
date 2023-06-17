using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using groupspace.Models;

namespace groupspace.Data
{
    public class groupspaceContext : DbContext
    {
        public groupspaceContext (DbContextOptions<groupspaceContext> options)
            : base(options)
        {
        }

        public DbSet<groupspace.Models.Group> Group { get; set; } = default!;
    }
}
