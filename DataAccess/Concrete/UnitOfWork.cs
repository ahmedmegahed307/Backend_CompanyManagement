using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private IBaseRepository<Resolution> resolutions = null;
        private IBaseRepository<Client> clients = null;
        private IBaseRepository<User> users = null;

        public readonly CompanyContext context;

       
        public IBaseRepository<Resolution> Resolutions
        {
            get
            {
                if (resolutions == null)
                {
                    resolutions = new BaseRepository<Resolution, CompanyContext>();

                }
                return resolutions;
            }
        }
        public IBaseRepository<Client> Clients
        {
            get
            {
                if (clients == null)
                {
                    clients = new BaseRepository<Client, CompanyContext>();

                }
                return clients;
            }
        }
        public IBaseRepository<User> Users
        {
            get
            {
                if (users == null)
                {
                    users = new BaseRepository<User, CompanyContext>();

                }
                return users;
            }
        }
        public void Dispose()
        {
            if(this.context != null)
            {
                this.context.Dispose();
            }
        }
        public CompanyContext Context
        {
            get
            {
                return context;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
