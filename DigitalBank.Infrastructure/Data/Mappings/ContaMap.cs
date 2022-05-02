using DigitalBank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalBank.Infrastructure.Data.Mappings
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Contas");

            builder.Property(p => p.id)
                .HasColumnType("bigint");

            builder.Property(p => p.cliente.id)
               .HasColumnType("bigint");

            builder.Property(p => p.numero)
               .HasColumnType("bigint");

            builder.Property(p => p.saldo)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.situacao)
              .HasColumnType("int");

            builder.Property(p => p.dataDeCadastro)
              .HasColumnType("datetime");

            builder.Property(p => p.dataDeFinalizacao)
              .HasColumnType("datetime");
        }
    }
}
