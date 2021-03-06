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
    public class DtoParaEntidadeEmpresa : Profile
    {
        public DtoParaEntidadeEmpresa()
        {
            DtoParaEmpresa();
        }

        private void DtoParaEmpresa()
        {
            CreateMap<EmpresaDto, Empresa>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.NomeFantasia, opt => opt.MapFrom(x => x.NomeFantasia))
                .ForMember(dest => dest.RazaoSocial, opt => opt.MapFrom(x => x.RazaoSocial))
                .ForMember(dest => dest.NumeroDocumento, opt => opt.MapFrom(x => x.Documento))
                .ForMember(dest => dest.UsuarioId, opt => opt.MapFrom(x => x.UsuarioId))
                .ForMember(dest => dest.Imagem, opt => opt.MapFrom(x => x.Imagem))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(x => x.Telefone))
                .ForMember(dest => dest.Licencas, opt => opt.MapFrom(x => x.Licencas));

        }
    }

}
