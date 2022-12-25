using Autofac;
using System.Reflection;
using TelephoneDirectory.Caching;
using TelephoneDirectory.Core.Repositories;
using TelephoneDirectory.Core.Services;
using TelephoneDirectory.Core.UnitOfWorks;
using TelephoneDirectory.Repository;
using TelephoneDirectory.Repository.Repositories;
using TelephoneDirectory.Repository.UnitOfWorks;
using TelephoneDirectory.Service.Mapping;
using TelephoneDirectory.Service.Services;
using Module = Autofac.Module;
namespace TelephoneDirectory.WebAPI.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(ServiceWithDto<,>)).As(typeof(IServiceWithDto<,>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<ProductServiceWithDto>().As<IProductServiceWithDto>().InstancePerLifetimeScope();

            var apiAssembly = Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssemblye = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssemblye).Where(x => x.Name.EndsWith
            ("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssemblye).Where(x => x.Name.EndsWith
            ("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();
            builder.RegisterType<CountryServiceWithCaching>().As<ICountryService>();
            builder.RegisterType<CityServiceWithCaching>().As<ICityService>();

        }
    }
}
