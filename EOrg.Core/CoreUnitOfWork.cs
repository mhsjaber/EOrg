using EOrg.Core.Membership;
using Proggasoft.Data.Hybrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOrg.Core
{
    public class CoreUnitOfWork : IDisposable, ICoreUnitOfWork
    {
        private CoreContext context;
        private IDbCommandExecutionService dbCommandExecutionService;
        private IDbCommandFactory dbCommandFactory;

        public CoreUnitOfWork(CoreContext context, IDbCommandExecutionService dbCommandExecutionService, IDbCommandFactory dbCommandFactory)
        {
            this.context = context;
            this.dbCommandExecutionService = dbCommandExecutionService;
            this.dbCommandFactory = dbCommandFactory;
        }

        private IGenericRepository<Customer> customerRepository;
        public IGenericRepository<Customer> CustomerRepository
        {
            get
            {
                if (this.customerRepository == null)
                {
                    this.customerRepository = new GenericRepository<Customer>(context, dbCommandExecutionService, dbCommandFactory);
                }
                return customerRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
