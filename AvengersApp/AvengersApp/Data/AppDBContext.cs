using AvengersApp.Models;
using Microsoft.EntityFrameworkCore;
namespace AvengersApp.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        { }

        public DbSet<Avengers> avengers {  get; set; }

    }
}
