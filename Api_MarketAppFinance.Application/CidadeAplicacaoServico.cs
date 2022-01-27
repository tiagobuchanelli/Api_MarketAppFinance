using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application
{
    public class CidadeAplicacaoServico : ICidadeAplicacaoServico
    {
        private readonly ICidadeSErvico<Cidade> _servicoCidade;
        private readonly IMapper _mapper;

        public CidadeAplicacaoServico(ICidadeSErvico<Cidade> servicoCidade, IMapper mapper)
        {
            _servicoCidade = servicoCidade;
            _mapper = mapper;
        }

        

        public IEnumerable<CidadeDto> BuscarTodos()
        => _mapper.Map<IEnumerable<CidadeDto>>(_servicoCidade.BuscarTodos());

        public CidadeDto BuscarPorCodigo(int id)
        => _mapper.Map<CidadeDto>(_servicoCidade.BuscarPorCodigo(id));

        public CidadeDto Adicionar(CidadeDto cidadeDto)
        {
            var cidade = _servicoCidade.AdicionarCidade(_mapper.Map<Cidade>(cidadeDto));
            return _mapper.Map<CidadeDto>(cidade);
        }

        public CidadeDto Atualizar(CidadeDto cidadeDto)
        {
            var cidade = _servicoCidade.AtualizarCidade(_mapper.Map<Cidade>(cidadeDto));
            return _mapper.Map<CidadeDto>(cidade);
        }

        public void Excluir(CidadeDto cidadeDto)
        => _servicoCidade.Excluir(_mapper.Map<Cidade>(cidadeDto));


    }
}