using EOrg.Core.Membership;
using EOrg.Core.Shop;
using Proggasoft.Data.Hybrid;

namespace EOrg.Core
{
    public interface ICoreUnitOfWork
    {
        IGenericRepository<Customer> CustomerRepository { get; }
        IGenericRepository<Product> ProductRepository { get; }
        IGenericRepository<Brand> BrandRepository { get; }
        IGenericRepository<SubCategory> SubCategoryRepository { get; }
        IGenericRepository<Category> CategoryRepository { get; }
        IGenericRepository<Color> ColorRepository { get; }
        void Save();
    }
}