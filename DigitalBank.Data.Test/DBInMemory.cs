using Microsoft.Data.Sqlite;
using DigitalBank.Data.Context;
using Microsoft.EntityFrameworkCore;
using DigitalBank.Domain.Entities;

namespace DigitalBank.Data.Test
{
    public class DBInMemory
    {
        private DataContext _context;
        public DBInMemory()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<DataContext>()
                .UseSqlite(connection)
                .EnableSensitiveDataLogging()
                .Options;

            _context = new DataContext(options);
            InsertFakeData();
        }

        public DataContext GetContext() => _context;

        private void InsertFakeData()
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
