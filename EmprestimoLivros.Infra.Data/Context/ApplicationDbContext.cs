using EmprestimoLivros.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Infra.Data.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Livro_Cliente_Emprestimo> Livro_Cliente_Emprestimo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
