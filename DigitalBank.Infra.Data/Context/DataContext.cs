using Microsoft.EntityFrameworkCore;
using DigitalBank.Domain.Entities;
using DigitalBank.Infra.Data.Config;

namespace DigitalBank.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }

        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        //{
        //    optionBuilder.UseSqlServer(DbConfig.getConnection());
        //}

    }
}
