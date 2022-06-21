using System;
using Microsoft.EntityFrameworkCore;

namespace Friello.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

       // public DbSet<> MyProperty { get; set; }
    }
}
