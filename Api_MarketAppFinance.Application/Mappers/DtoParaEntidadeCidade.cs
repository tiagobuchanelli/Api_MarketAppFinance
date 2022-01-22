using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class DtoParaEntidadeCidade : Profile
    {
        public DtoParaEntidadeCidade()
        {
            DtoParaCidade();
        }

        private void DtoParaCidade()
        {
            CreateMap<CidadeDto, Cidade>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Cep, opt => opt.MapFrom(x => x.ZipCode))
                .ForMember(dest => dest.CodigoIbge, opt => opt.MapFrom(x => x.CodeIgbe))
                .ForMember(dest => dest.CodigoIbgeEstado, opt => opt.MapFrom(x => x.StateCodeIgbe))
                .ForMember(dest => dest.SiglaEstado, opt => opt.MapFrom(x => x.StateSymbol));
        }
    }
}