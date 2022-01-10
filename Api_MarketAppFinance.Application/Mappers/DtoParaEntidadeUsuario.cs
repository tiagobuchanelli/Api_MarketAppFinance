using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Application.Mappers
{
    public class DtoParaEntidadeUsuario : Profile
    {
        public DtoParaEntidadeUsuario()
        {
            DtoParaUsuario();
                
        }

        private void DtoParaUsuario()
        {
            CreateMap<UsuarioDto, Usuario>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(x => x.LastName))
                .ForMember(dest => dest.Imagem, opt => opt.MapFrom(x => x.Image))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(x => x.Phone));

        }
    }
}
