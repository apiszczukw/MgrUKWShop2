

using MgrUKWShop2.Models;
using Microsoft.EntityFrameworkCore;

namespace MgrUKWShop2.DAL
{
    public class FilmsContext : DbContext
    {
        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Film> Films { get; set; }
    }
}
