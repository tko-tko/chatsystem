using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using chatsystem.Models;

namespace chatsystem.Data
{
    public class chatsystemContext : DbContext
    {
        public chatsystemContext (DbContextOptions<chatsystemContext> options)
            : base(options)
        {
        }

        public DbSet<chatsystem.Models.Movie> Movie { get; set; } = default!;
    }
}
