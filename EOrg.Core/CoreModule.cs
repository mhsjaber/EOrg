using Ninject.Modules;
using Proggasoft.Data.Hybrid;
using Proggasoft.Diagnosis;
using Proggasoft.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Bind<CoreContext>().ToSelf();
        }
    }
}
