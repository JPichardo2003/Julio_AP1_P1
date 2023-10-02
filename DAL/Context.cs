using Julio_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;
namespace Julio_AP1_P1.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Aportes> Aportes { get; set;}
    }
}
