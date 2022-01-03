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
    public class DtoToModelMappingCity : Profile
    {
        public DtoToModelMappingCity()
        {
            CityToMap();
                
        }

        private void CityToMap()
        {
            CreateMap<CityDto, City>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(x => x.ZipCode))
                .ForMember(dest => dest.CodeIgbe, opt => opt.MapFrom(x => x.CodeIgbe))
                .ForMember(dest => dest.StateCodeIgbe, opt => opt.MapFrom(x => x.StateCodeIgbe))
                .ForMember(dest => dest.StateSymbol, opt => opt.MapFrom(x => x.StateSymbol));

        }
    }
}
