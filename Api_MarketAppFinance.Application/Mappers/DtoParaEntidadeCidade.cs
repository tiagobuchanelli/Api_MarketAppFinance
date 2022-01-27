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
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Cep, opt => opt.MapFrom(x => x.Cep))
                .ForMember(dest => dest.CodigoIbge, opt => opt.MapFrom(x => x.CodigoIbge))
                .ForMember(dest => dest.CodigoIbgeEstado, opt => opt.MapFrom(x => x.CodigoIbgeEstado))
                .ForMember(dest => dest.SiglaEstado, opt => opt.MapFrom(x => x.SiglaEstado));
        }
    }
}