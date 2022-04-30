using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Data.Configurations
{
    static class DbConfiguration
    {
        private const string _connectionString = "Data Source = localhost; Initial Catalog = digitalbank; Integrated Security = True;";

        public static string getConnection()
        {
            return _connectionString;
        }
    }
}
