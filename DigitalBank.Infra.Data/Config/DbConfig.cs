using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Infra.Data.Config
{
    static class DbConfig
    {
        // PARA CRIAR O BD COM MIGRATIONS NO SQL SERVER LOCAL
        //private const string _connectionString = @"Data Source=localhost;Initial Catalog=digitalbank;Integrated Security=True;";

        // PARA CRIAR O BD COM MIGRATIONS NO SQL SERVER DO CONTAINER DO DOCKER
        private const string _connectionString = @"Data Source=localhost,1433;Initial Catalog=digitalbank;Persist Security Info=True;User ID=SA;Password=Senha#123";

        public static string getConnection()
        {
            return _connectionString;
        }
    }
}