using Api_MarketAppFinance.Application;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Application.Mappers;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Domain.Services;
using Api_MarketAppFinance.Infrastructure.Data.Repositories;
using Autofac;
using AutoMapper;
using MarketAppFinanceSApi_MarketAppFinanceervice.Application;

namespace Api_MarketAppFinance.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceUser>().As<IApplicationServiceUser>();
            builder.RegisterType<ApplicationServiceCity>().As<IApplicationServiceCity>();

            builder.RegisterType<ServiceUser>().As<IServiceUser>();
            builder.RegisterType<ServiceCity>().As<IServiceCity>();

            builder.RegisterType<RepositoryUser>().As<IRepositoryUser>();
            builder.RegisterType<RepositoryCity>().As<IRepositoryCity>();
            

            builder.Register(ctx => new MapperConfiguration(cfg =>
           {
               cfg.AddProfile(new DtoToModelMappingUser());
               cfg.AddProfile(new ModelToDtoMappingUser());
               cfg.AddProfile(new ModelToDtoMappingCity());
               cfg.AddProfile(new DtoToModelMappingCity());
           }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            #endregion IOC
        }
    }
}