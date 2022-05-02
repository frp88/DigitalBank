
using DigitalBank.Domain.Entities;
using DigitalBank.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;


namespace DigitalBank.Infrastructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }

        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        //{
        //    optionBuilder.UseSqlServer(DbConfiguration.getConnection());
        //}

    }
}
