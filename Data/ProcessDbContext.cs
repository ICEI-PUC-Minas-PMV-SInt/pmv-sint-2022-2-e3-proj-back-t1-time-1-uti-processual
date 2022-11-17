using Microsoft.EntityFrameworkCore;
using utip_backend.Models;

namespace utip_backend.Data
{
    public class ProcessDbContext:DbContext
    {
        public ProcessDbContext(DbContextOptions<ProcessDbContext> options) : base(options) 
        {            
        }

        public DbSet<ProcessModel> Processo { get; set; }
    }
}
