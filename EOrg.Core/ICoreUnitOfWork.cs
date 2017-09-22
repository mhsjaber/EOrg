using EOrg.Core.Membership;
using Proggasoft.Data.Hybrid;

namespace EOrg.Core
{
    public interface ICoreUnitOfWork
    {
        IGenericRepository<Customer> CustomerRepository { get; }
        void Save();
    }
}