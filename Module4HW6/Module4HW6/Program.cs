using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WorkingWithDB.DBContexts;
using WorkingWithDB.Configs;
using WorkingWithDB.Models;

namespace WorkingWithDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connConfig = new ConnectionConfig();
            string? connectionString = connConfig.Build().GetConnectionString("DefaultConnection");

            if (connectionString != null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
                var options = optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString).Options;
            }
        }
    }
}