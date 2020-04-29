using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Project_480_V11.Models
{
    public class BracketDbContext : DbContext
    {
        public BracketDbContext(DbContextOptions<BracketDbContext> options) : base(options)
        {

        }

        public DbSet<BracketInput> Brackets { get; set; }
    }
}
