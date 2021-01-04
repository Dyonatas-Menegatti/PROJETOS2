using Microsoft.EntityFrameworkCore;
using SiteModeloAPI.Model;

namespace SiteModeloAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Parametro> Parametros { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parametro>()
                .HasKey(o => o.PessoaId);
        }

    }
}