using Api_MarketAppFinance.Application.Mappers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Testes.MapperMock
{
    public class MockMapper
    {
        public MockMapper()
        {
            ObterMappers();

        }
        public Mapper ObterMappers()
        {
            var _configuration = new MapperConfiguration(cfg =>
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
            });

            return new Mapper(_configuration);
        }
    }
}
