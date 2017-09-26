using Ninject.Modules;
using Proggasoft.Data.Hybrid;
using Proggasoft.Diagnosis;
using Proggasoft.Utility;

namespace EOrg.Core
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IReflectionHelper>().To<ReflectionHelper>().InSingletonScope();
            Bind<IDbCommandExecutionService>().To<DbCommandExecutionService>().InSingletonScope();
            Bind<IDbCommandFactory>().To<SqlCommandFactory>().InSingletonScope().WithConstructorArgument("connectionString",
                new ConnectionStringReader().ConnectionString);

            Bind<ILogHelperFactory>().To<Log4NetLogHelperFactory>().InSingletonScope();
            Bind<ICoreUnitOfWork>().To<CoreUnitOfWork>();
            Bind<IServerTime>().To<ServerTime>();
            Bind<CoreContext>().ToSelf();
        }
    }
}
