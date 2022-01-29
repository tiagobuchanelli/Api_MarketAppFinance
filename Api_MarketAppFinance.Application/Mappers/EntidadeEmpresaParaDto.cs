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
    public class EntidadeEmpresaParaDto : Profile
    {
        public EntidadeEmpresaParaDto()
        {
            EmpresaParaDto();
        }

        private void EmpresaParaDto()
        {
            CreateMap<Empresa, EmpresaDto>()
              .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
              .ForMember(dest => dest.NomeFantasia, opt => opt.MapFrom(x => x.NomeFantasia))
              .ForMember(dest => dest.RazaoSocial, opt => opt.MapFrom(x => x.RazaoSocial))
              .ForMember(dest => dest.Documento, opt => opt.MapFrom(x => x.NumeroDocumento))
              .ForMember(dest => dest.Imagem, opt => opt.MapFrom(x => x.Imagem))
              .ForMember(dest => dest.UsuarioId, opt => opt.Ignore())
              .ForMember(dest => dest.Usuario, opt => opt.MapFrom(x => x.Usuario))
              .ForMember(dest => dest.Licencas, opt => opt.MapFrom(x => x.Licencas)); 
        }
    }

}
