using LuisJose_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace LuisJose_AP1_P1.DAL
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }

        public DbSet<Aportes> Aportes { get; set; }
    }
}
