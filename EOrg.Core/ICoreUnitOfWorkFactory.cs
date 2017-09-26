namespace EOrg.Core
{
    public interface ICoreUnitOfWorkFactory
    {
        ICoreUnitOfWork CreateUnitOfWork();
    }
}