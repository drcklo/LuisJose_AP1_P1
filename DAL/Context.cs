using Microsoft.EntityFrameworkCore;

namespace LuisJose_AP1_P1.DAL
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
    }
}
