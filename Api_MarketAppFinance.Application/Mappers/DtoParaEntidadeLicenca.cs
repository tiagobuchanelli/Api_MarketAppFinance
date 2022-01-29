using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class DtoParaEntidadeLicenca : Profile
    {
        public DtoParaEntidadeLicenca()
        {
            DtoParaLicenca();
        }

        private void DtoParaLicenca()
        {
            CreateMap<LicencaDto, Licenca>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(dest => dest.Tipo, opt => opt.MapFrom(x => x.Tipo))
                .ForMember(dest => dest.NumeroAcessosPermitido, opt => opt.MapFrom(x => x.NumeroAcecsso))
                .ForMember(dest => dest.Chave, opt => opt.MapFrom(x => x.Chave))
                .ForMember(dest => dest.DataExpiracao, opt => opt.MapFrom(x => x.DataValidade));
        }
    }
}