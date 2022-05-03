using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using DigitalBank.Domain.Entities;
using DigitalBank.Infra.Data.Context;

namespace DigitalBank.Infra.Data.Tests
{
    public class DbInMemory
    {
        private DataContext _context;
        public DbInMemory()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<DataContext>()
                .UseSqlite(connection)
                .EnableSensitiveDataLogging()
                .Options;

            _context = new DataContext(options);
            InsereDadosFicticios();
        }

        public DataContext GetContext() => _context;

        private void InsereDadosFicticios()
        {
            if (_context.Database.EnsureCreated())
            {
                _context.Clientes.Add(
                    new Cliente("Maria", "12345678900")
                );
                _context.Clientes.Add(
                    new Cliente("José", "98765432100")
               );
                _context.Clientes.Add(
                     new Cliente("Ana Maria", "55533377799")
                );

                _context.SaveChanges();
            }
        }
    }
}
