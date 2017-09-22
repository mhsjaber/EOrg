using EOrg.Core.Membership;
using EOrg.Core.Shop;
using Proggasoft.Data.Hybrid;
using System;

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

        private IGenericRepository<Product> productRepository;
        public IGenericRepository<Product> ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(context, dbCommandExecutionService, dbCommandFactory);
                }
                return productRepository;
            }
        }

        private IGenericRepository<Brand> brandRepository;
        public IGenericRepository<Brand> BrandRepository
        {
            get
            {
                if (this.brandRepository == null)
                {
                    this.brandRepository = new GenericRepository<Brand>(context, dbCommandExecutionService, dbCommandFactory);
                }
                return brandRepository;
            }
        }

        private IGenericRepository<Category> categoryRepository;
        public IGenericRepository<Category> CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new GenericRepository<Category>(context, dbCommandExecutionService, dbCommandFactory);
                }
                return categoryRepository;
            }
        }

        private IGenericRepository<SubCategory> subCategoryRepository;
        public IGenericRepository<SubCategory> SubCategoryRepository
        {
            get
            {
                if (this.subCategoryRepository == null)
                {
                    this.subCategoryRepository = new GenericRepository<SubCategory>(context, dbCommandExecutionService, dbCommandFactory);
                }
                return subCategoryRepository;
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
