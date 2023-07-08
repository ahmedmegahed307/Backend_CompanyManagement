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
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<JobSubType> JobSubTypes { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Engineer> Engineers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-7ISV675\\SQLEXPRESS;Initial Catalog=CompanyManagement;Integrated Security=True;TrustServerCertificate=True",
                b => b.MigrationsAssembly("WebAPI"));
        }

       
    }
}
