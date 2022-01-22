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

        public void Adicionar(CidadeDto cityDto)
        {
            var city = _mapper.Map<Cidade>(cityDto);
            _serviceCity.Adicionar(city);
        }

        public IEnumerable<CidadeDto> BuscarTodos()
        {
            var cities = _serviceCity.BuscarTodos();
            return _mapper.Map<IEnumerable<CidadeDto>>(cities);
        }

        public CidadeDto BuscarPorCodigo(int id)
        {
            var city = _serviceCity.BuscarPorCodigo(id);
            return _mapper.Map<CidadeDto>(city);
        }

        public void Excluir(CidadeDto cityDto)
        {
            var city = _mapper.Map<Cidade>(cityDto);
            _serviceCity.Excluir(city);
        }

        public void Atualizar(CidadeDto cityDto)
        {
            var city = _mapper.Map<Cidade>(cityDto);
            _serviceCity.Atualizar(city);
        }
    }
}