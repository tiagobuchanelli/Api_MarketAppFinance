using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class DtoParaEntidadeFormaPagamento : Profile
    {
        public DtoParaEntidadeFormaPagamento()
        {
            DtoParaFormaPagamento();
        }

        private void DtoParaFormaPagamento()
        {
            CreateMap<FormaPagamentoDto, FormaPagamento>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(dest => dest.TipoPagamento, opt => opt.MapFrom(x => x.TipoPagamento))
                .ForMember(dest => dest.CarteiraId, opt => opt.MapFrom(x => x.CarteiraId))
                .ForMember(dest => dest.EmpresaId, opt => opt.MapFrom(x => x.EmpresaId))
                .ForMember(dest => dest.Abreviacao, opt => opt.MapFrom(x => x.Abreviacao))
                .ForMember(dest => dest.ValorAcrescimo, opt => opt.MapFrom(x => x.ValorAcrescimo))
                .ForMember(dest => dest.ValorDesconto, opt => opt.MapFrom(x => x.ValorDesconto))
                .ForMember(dest => dest.PrDesconto, opt => opt.MapFrom(x => x.PercentualDesconto))
                .ForMember(dest => dest.PrAcrescimo, opt => opt.MapFrom(x => x.PercentualAcrescimo))
                .ForMember(dest => dest.NrDiasIntervalo, opt => opt.MapFrom(x => x.DiasIntervalo))
                .ForMember(dest => dest.NrDiasLimiteIntervalo, opt => opt.MapFrom(x => x.DiasLimiteIntervalo))
                .ForMember(dest => dest.NrIntervalos, opt => opt.MapFrom(x => x.NumeroIntervalos))
                .ForMember(dest => dest.DiaPadraoVencimento, opt => opt.MapFrom(x => x.DiaPadraoVencimento))
                .ForMember(dest => dest.GerarFinanceiro, opt => opt.MapFrom(x => x.GerarFinanceiro));
        }
    }
}