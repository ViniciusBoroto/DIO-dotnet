using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.Entities;

namespace MinhaPrimeiraAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }
        public DbSet<Contato> Contato { get; set; }
    }
}
