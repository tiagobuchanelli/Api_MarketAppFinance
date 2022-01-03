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
    public class DtoToModelMappingUser : Profile
    {
        public DtoToModelMappingUser()
        {
            UserToMap();
                
        }

        private void UserToMap()
        {
            CreateMap<UserDto, User>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(x => x.LastName))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(x => x.Image))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(x => x.Phone));

        }
    }
}
