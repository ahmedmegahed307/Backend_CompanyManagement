using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.InfraStructure
{
    public static class DatabaseConfiguration
    {
        public static void Configure(DbContextOptionsBuilder optionsBuilder, IConfiguration configuration)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CompanyContext"));
        }
    }
}
