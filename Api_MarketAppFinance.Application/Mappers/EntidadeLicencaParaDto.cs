using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class EntidadeLicencaParaDto : Profile
    {
        public EntidadeLicencaParaDto()
        {
            LicencaParaDto();
        }

        private void LicencaParaDto()
        {
            CreateMap<Licenca, LicencaDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(dest => dest.Tipo, opt => opt.MapFrom(x => x.Tipo))
                .ForMember(dest => dest.NumeroAcecsso, opt => opt.MapFrom(x => x.NumeroAcessosPermitido))
                .ForMember(dest => dest.Chave, opt => opt.MapFrom(x => x.Chave))
                .ForMember(dest => dest.DataValidade, opt => opt.MapFrom(x => x.DataExpiracao));
        }
    }
}