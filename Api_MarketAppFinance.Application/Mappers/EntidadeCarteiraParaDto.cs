using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class EntidadeCarteiraParaDto : Profile
    {
        public EntidadeCarteiraParaDto()
        {
            CarteiraParaDto();
        }

        private void CarteiraParaDto()
        {
            CreateMap<Carteira, CarteiraDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(dest => dest.Abreviacao, opt => opt.MapFrom(x => x.Abreviacao))
                .ForMember(dest => dest.EmpresaId, opt => opt.Ignore())
                .ForMember(dest => dest.Empresa, opt => opt.MapFrom(x => x.Empresa))                
                .ForMember(dest => dest.ValorMinimoVenda, opt => opt.MapFrom(x => x.ValorMinimoVenda));
        }
    }
}