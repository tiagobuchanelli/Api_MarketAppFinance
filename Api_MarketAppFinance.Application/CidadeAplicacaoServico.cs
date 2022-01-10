using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application
{
    public class CidadeAplicacaoServico : ICidadeAplicacaoServico
    {
        private readonly ICidadeSErvico _serviceCity;
        private readonly IMapper _mapper;

        public CidadeAplicacaoServico(ICidadeSErvico serviceCity, IMapper mapper)
        {
            _serviceCity = serviceCity;
            _mapper = mapper;
        }

        public void Add(CidadeDto cityDto)
        {
            var city = _mapper.Map<Cidade>(cityDto);
            _serviceCity.Add(city);
        }

        public IEnumerable<CidadeDto> GetAll()
        {
            var cities = _serviceCity.GetAll();
            return _mapper.Map<IEnumerable<CidadeDto>>(cities);
        }

        public CidadeDto GetById(int id)
        {
            var city = _serviceCity.GetById(id);
            return _mapper.Map<CidadeDto>(city);
        }

        public void Remove(CidadeDto cityDto)
        {
            var city = _mapper.Map<Cidade>(cityDto);
            _serviceCity.Remove(city);
        }

        public void Update(CidadeDto cityDto)
        {
            var city = _mapper.Map<Cidade>(cityDto);
            _serviceCity.Update(city);
        }
    }
}