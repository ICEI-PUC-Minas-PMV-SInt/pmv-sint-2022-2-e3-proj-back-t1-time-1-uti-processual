using UTIProcessual.Models.Cadastro;
using Microsoft.EntityFrameworkCore;

namespace UTIProcessual.Data
{
    internal sealed class MVCDbContext : DbContext
    {
        public DbSet<NovoProcesso> CadastroProcessos { get; set; }

        private const string connectionString = "server=localhost;port=3306;database=utiprocessual;user=root;password=fakemonalisa";
        ServerVersion sv = MariaDbServerVersion.AutoDetect(connectionString);

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseMySql(connectionString, sv);
        }
    }
}
