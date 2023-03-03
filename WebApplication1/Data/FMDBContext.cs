
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class FMDBContext:DbContext
    {
        public FMDBContext(DbContextOptions<FMDBContext> options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; } 
    }
}
