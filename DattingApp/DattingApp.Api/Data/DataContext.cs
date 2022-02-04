using DattingApp.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace DattingApp.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options):base(options) { }

        public DbSet<AppUser> User { get; set; }
    }
}
