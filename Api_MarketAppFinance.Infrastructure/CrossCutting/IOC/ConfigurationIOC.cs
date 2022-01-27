using Api_MarketAppFinance.Application;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Application.Mappers;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
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

            //mapeamento ApplicationService
            builder.RegisterType<UsuarioAplicacaoServico>().As<IUsuarioAplicacaoServico>();
            builder.RegisterType<CidadeAplicacaoServico>().As<ICidadeAplicacaoServico>();


            //mapeamento Service
            builder.RegisterType<UsuarioServico>().As<IUsuarioServico<Usuario>>();
            builder.RegisterType<CidadeSErvico>().As<ICidadeSErvico<Cidade>>();

            builder.RegisterType<UsuarioRepositorio>().As<IUsuarioRepositorio<Usuario>>();
            builder.RegisterType<CidadeRepositorio>().As<ICidadeRepositorio<Cidade>>();

            //mapeamento DTOs
            builder.Register(ctx => new MapperConfiguration(cfg =>
           {
               cfg.AddProfile(new DtoParaEntidadeUsuario());
               cfg.AddProfile(new EntidadeUsuarioParaDto());
               cfg.AddProfile(new EntidadeCidadeParaDto());
               cfg.AddProfile(new DtoParaEntidadeCidade());
           }));

            //registro de estado Mapper
            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            #endregion IOC
        }
    }
}