using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class DtoParaEntidadeCarteira : Profile
    {
        public DtoParaEntidadeCarteira()
        {
            DtoParaCarteira();
        }

        private void DtoParaCarteira()
        {
            CreateMap<CarteiraDto, Carteira>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(dest => dest.Abreviacao, opt => opt.MapFrom(x => x.Abreviacao))
                .ForMember(dest => dest.EmpresaId, opt => opt.MapFrom(x => x.EmpresaId))
                .ForMember(dest => dest.ValorMinimoVenda, opt => opt.MapFrom(x => x.ValorMinimoVenda));
        }
    }
}