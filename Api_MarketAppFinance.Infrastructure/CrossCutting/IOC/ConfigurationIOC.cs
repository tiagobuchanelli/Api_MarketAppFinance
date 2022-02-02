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
            builder.RegisterType<EmpresaAplicacaoServico>().As<IEmpresaAplicacaoServico>();
            builder.RegisterType<CarteiraAplicacaoServico>().As<ICarteiraAplicacaoServico>();
            builder.RegisterType<FormaPagamentoAplicacaoServico>().As<IFormaPagamentoAplicacaoServico>();


            //mapeamento Service
            builder.RegisterType<UsuarioServico>().As<IUsuarioServico<Usuario>>();
            builder.RegisterType<CidadeServico>().As<ICidadeServico<Cidade>>();
            builder.RegisterType<EmpresaServico>().As<IEmpresaServico<Empresa>>();
            builder.RegisterType<CarteiraServico>().As<ICarteiraServico<Carteira>>();
            builder.RegisterType<FormaPagamentoServico>().As<IFormaPagamentoServico<FormaPagamento>>();

            builder.RegisterType<UsuarioRepositorio>().As<IUsuarioRepositorio<Usuario>>();
            builder.RegisterType<CidadeRepositorio>().As<ICidadeRepositorio<Cidade>>();
            builder.RegisterType<EmpresaRepositorio>().As<IEmpresaRepositorio<Empresa>>();
            builder.RegisterType<LicencaRepositorio>().As<ILicencaRepositorio<Licenca>>();
            builder.RegisterType<CarteiraRepositorio>().As<ICarteiraRepositorio<Carteira>>();
            builder.RegisterType<FormaPagamentoRepositorio>().As<IFormaPagamentoRepositorio<FormaPagamento>>();

            //mapeamento DTOs
            builder.Register(ctx => new MapperConfiguration(cfg =>
           {
               cfg.AddProfile(new DtoParaEntidadeUsuario());
               cfg.AddProfile(new EntidadeUsuarioParaDto());

               cfg.AddProfile(new EntidadeCidadeParaDto());
               cfg.AddProfile(new DtoParaEntidadeCidade());

               cfg.AddProfile(new EntidadeEmpresaParaDto());
               cfg.AddProfile(new DtoParaEntidadeEmpresa());

               cfg.AddProfile(new EntidadeLicencaParaDto());
               cfg.AddProfile(new DtoParaEntidadeLicenca());

               cfg.AddProfile(new EntidadeCarteiraParaDto());
               cfg.AddProfile(new DtoParaEntidadeCarteira());

               cfg.AddProfile(new EntidadeFormaPagamentoParaDto());
               cfg.AddProfile(new DtoParaEntidadeFormaPagamento());
           }));

            //registro de estado Mapper
            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            #endregion IOC
        }
    }
}