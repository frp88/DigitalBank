using DigitalBank.Data.Configurations;
using DigitalBank.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DigitalBank.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<ContaCorrente> ContasCorrentes { get; set; }
        
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(DbConfiguration.getConnection());
        }

    }
}
