using EOrg.Core.Membership;
using EOrg.Core.Shop;
using Proggasoft.Data.Hybrid;
using System;

namespace EOrg.Core
{
    public class CoreUnitOfWork : IDisposable, ICoreUnitOfWork
    {
        private readonly CoreContext _context;
        private readonly IDbCommandExecutionService _dbCommandExecutionService;
        private readonly IDbCommandFactory _dbCommandFactory;

        public CoreUnitOfWork(CoreContext context, IDbCommandExecutionService dbCommandExecutionService, IDbCommandFactory dbCommandFactory)
        {
            _context = context;
            _dbCommandExecutionService = dbCommandExecutionService;
            _dbCommandFactory = dbCommandFactory;
        }

        private IGenericRepository<Customer> _customerRepository;
        public IGenericRepository<Customer> CustomerRepository => _customerRepository ?? (_customerRepository =
                                                                      new GenericRepository<Customer>(_context, _dbCommandExecutionService, _dbCommandFactory));

        private IGenericRepository<Product> _productRepository;
        public IGenericRepository<Product> ProductRepository => _productRepository ?? (_productRepository =
                                                                    new GenericRepository<Product>(_context, _dbCommandExecutionService, _dbCommandFactory));

        private IGenericRepository<Brand> _brandRepository;
        public IGenericRepository<Brand> BrandRepository => _brandRepository ?? (_brandRepository =
                                                                new GenericRepository<Brand>(_context, _dbCommandExecutionService, _dbCommandFactory));

        private IGenericRepository<Category> _categoryRepository;
        public IGenericRepository<Category> CategoryRepository => _categoryRepository ?? (_categoryRepository =
                                                                      new GenericRepository<Category>(_context, _dbCommandExecutionService, _dbCommandFactory));

        private IGenericRepository<SubCategory> _subCategoryRepository;
        public IGenericRepository<SubCategory> SubCategoryRepository => _subCategoryRepository ?? (_subCategoryRepository =
                                                                            new GenericRepository<SubCategory>(_context, _dbCommandExecutionService, _dbCommandFactory));

        private IGenericRepository<Color> _colorRepository;
        public IGenericRepository<Color> ColorRepository => _colorRepository ?? (_colorRepository =
                                                                new GenericRepository<Color>(_context, _dbCommandExecutionService, _dbCommandFactory));

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
