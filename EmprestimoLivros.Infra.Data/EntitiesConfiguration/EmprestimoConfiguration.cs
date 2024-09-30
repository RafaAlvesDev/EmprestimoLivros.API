using EmprestimoLivros.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmprestimoLivros.Infra.Data.EntitiesConfiguration
{
    public class EmprestimoConfiguration : IEntityTypeConfiguration<Livro_Cliente_Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Livro_Cliente_Emprestimo> builder)
        {
            builder.HasKey(X => X.Id);
            builder.Property(X => X.IdCliente).IsRequired();
            builder.Property(X => X.IdLivro).IsRequired();
            builder.Property(X => X.DataEmprestimo).IsRequired();
            builder.Property(X => X.DataEntrega).IsRequired();
            builder.Property(X => X.Entregue).IsRequired();

            builder.HasOne(x => x.Cliente).WithMany(x => x.Emprestimos)
                .HasForeignKey(x => x.IdCliente).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Livro).WithMany(x => x.Emprestimos)
                .HasForeignKey(x => x.IdLivro).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
