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
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(x => x.Cep))
                .ForMember(dest => dest.CodeIgbe, opt => opt.MapFrom(x => x.CodigoIbge))
                .ForMember(dest => dest.StateCodeIgbe, opt => opt.MapFrom(x => x.CodigoIbgeEstado))
                .ForMember(dest => dest.StateSymbol, opt => opt.MapFrom(x => x.SiglaEstado));
        }
    }
}
