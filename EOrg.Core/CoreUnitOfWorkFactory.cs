using Proggasoft.Data.Hybrid;
using Proggasoft.Utility;

namespace EOrg.Core
{
    public class CoreUnitOfWorkFactory : ICoreUnitOfWorkFactory
    {
        public ICoreUnitOfWork CreateUnitOfWork()
        {
            return new CoreUnitOfWork(new CoreContext(), new DbCommandExecutionService(), 
                new SqlCommandFactory(new ConnectionStringReader().ConnectionString));
        }
    }
}
