using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class EntidadeCidadeParaDto : Profile
    {
        public EntidadeCidadeParaDto()
        {
            CidadeParaDto();
        }

        private void CidadeParaDto()
        {
            CreateMap<Cidade, CidadeDto>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Cep, opt => opt.MapFrom(x => x.Cep))
                .ForMember(dest => dest.CodigoIbge, opt => opt.MapFrom(x => x.CodigoIbge))
                .ForMember(dest => dest.CodigoIbgeEstado, opt => opt.MapFrom(x => x.CodigoIbgeEstado))
                .ForMember(dest => dest.SiglaEstado, opt => opt.MapFrom(x => x.SiglaEstado));
        }
    }
}