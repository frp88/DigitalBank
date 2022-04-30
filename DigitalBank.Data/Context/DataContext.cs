using DigitalBank.Data.Configurations;
using DigitalBank.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace DigitalBank.Data.Context
{
    public class AppDataContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }

        public DbSet<ContaCorrente> ContasCorrentes { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        public AppDataContext() { }

        //public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(DbConfiguration.getConnection());

            //optionBuilder.UseSqlServer(@"Data Source = localhost; Initial Catalog = digitalbank; Integrated Security = True;");

        }
    }
}
