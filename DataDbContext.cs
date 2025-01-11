using main1234.Models;
using Microsoft.EntityFrameworkCore;

namespace main1234.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext (DbContextOptions<DataDbContext> options) : base(options)
        {
        }

        public DbSet<ContactModel> ContactModel { get; set; }
        public DbSet<PostModel> PostModel { get; set; }
    }
}
