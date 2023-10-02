using Alexander_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace Alexander_AP1_P1.DAL
{
    public class Context: DbContext
    {
        public DbSet<Aportes> Aportes { get; set; }
        public Context(DbContextOptions<Context> options):base(options) 
        { }
    }
}
