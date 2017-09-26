using EOrg.Core.Membership;
using EOrg.Core.Shop;
using Proggasoft.Data.Hybrid;
using System;

namespace EOrg.Core
{
    public interface ICoreUnitOfWork : IDisposable
    {
        IGenericRepository<Customer> CustomerRepository { get; }
        IGenericRepository<Product> ProductRepository { get; }
        IGenericRepository<Brand> BrandRepository { get; }
        IGenericRepository<SubCategory> SubCategoryRepository { get; }
        IGenericRepository<Category> CategoryRepository { get; }
        IGenericRepository<Color> ColorRepository { get; }
        IGenericRepository<Sell> SellRepository { get; }
        IGenericRepository<Installment> InstallmentRepository { get; }
        void Save();
    }
}