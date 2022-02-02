using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class EntidadeFormaPagamentoParaDto : Profile
    {
        public EntidadeFormaPagamentoParaDto()
        {
            FormaPagamentoParaDto();
        }

        private void FormaPagamentoParaDto()
        {
            CreateMap<FormaPagamento, FormaPagamentoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(dest => dest.TipoPagamento, opt => opt.MapFrom(x => x.TipoPagamento))
                .ForMember(dest => dest.Carteira, opt => opt.Ignore())
                .ForMember(dest => dest.Empresa, opt => opt.Ignore())
                .ForMember(dest => dest.EmpresaId, opt => opt.Ignore())
                .ForMember(dest => dest.Abreviacao, opt => opt.MapFrom(x => x.Abreviacao))
                .ForMember(dest => dest.ValorAcrescimo, opt => opt.MapFrom(x => x.ValorAcrescimo))
                .ForMember(dest => dest.ValorDesconto, opt => opt.MapFrom(x => x.ValorDesconto))
                .ForMember(dest => dest.PercentualDesconto, opt => opt.MapFrom(x => x.PrDesconto))
                .ForMember(dest => dest.PercentualAcrescimo, opt => opt.MapFrom(x => x.PrAcrescimo))
                .ForMember(dest => dest.DiasIntervalo, opt => opt.MapFrom(x => x.NrDiasIntervalo))
                .ForMember(dest => dest.DiasLimiteIntervalo, opt => opt.MapFrom(x => x.NrDiasLimiteIntervalo))
                .ForMember(dest => dest.NumeroIntervalos, opt => opt.MapFrom(x => x.NrIntervalos))
                .ForMember(dest => dest.DiaPadraoVencimento, opt => opt.MapFrom(x => x.DiaPadraoVencimento))
                .ForMember(dest => dest.GerarFinanceiro, opt => opt.MapFrom(x => x.GerarFinanceiro));
        }
    }
}