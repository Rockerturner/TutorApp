using Microsoft.EntityFrameworkCore;
using TutorApp.API.Models;

namespace TutorApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Value> Values {get; set;}
    }
}