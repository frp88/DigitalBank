using DigitalBank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalBank.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.Property(p => p.id)
                .HasColumnType("bigint");

            builder.Property(p => p.nome)
               .HasColumnType("varchar(255)");

            builder.Property(p => p.cpf)
                .HasColumnType("varchar(11)");

            builder.Property(p => p.email)
                .HasColumnType("varchar(255)");

            builder.Property(p => p.dataDeNascimento)
               .HasColumnType("datetime");

            builder.Property(p => p.dataDeCadastro)
              .HasColumnType("datetime");

            builder.Property(p => p.situacao)
              .HasColumnType("int");
        }
    }
}
