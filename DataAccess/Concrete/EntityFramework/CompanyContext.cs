using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CompanyContext :DbContext
    {
        public CompanyContext()
        {
            
        }
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
        }

        public virtual DbSet<Resolution> Resolutions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-7ISV675\\SQLEXPRESS;Initial Catalog=CompanyManagement;Integrated Security=True;TrustServerCertificate=True",
                b => b.MigrationsAssembly("WebAPI"));
        }

       
    }
}
