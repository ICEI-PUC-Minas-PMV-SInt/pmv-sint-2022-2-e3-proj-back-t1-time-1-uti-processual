using UTIProcessual.Models.Cadastro;
using Microsoft.EntityFrameworkCore;

namespace UTIProcessual.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<NovoProcesso> Processos { get; set; }
    }
}
