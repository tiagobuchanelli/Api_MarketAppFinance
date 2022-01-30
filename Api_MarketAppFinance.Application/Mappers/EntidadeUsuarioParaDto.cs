using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class EntidadeUsuarioParaDto : Profile
    {
        public EntidadeUsuarioParaDto()
        {
            UsuarioParaDto();
        }

        private void UsuarioParaDto()
        {
            CreateMap<Usuario, UsuarioDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(x => x.Sobrenome))
                .ForMember(dest => dest.Imagem, opt => opt.MapFrom(x => x.Imagem))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Senha, opt => opt.MapFrom(x => x.Senha))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(x => x.Telefone));
        }
    }
}