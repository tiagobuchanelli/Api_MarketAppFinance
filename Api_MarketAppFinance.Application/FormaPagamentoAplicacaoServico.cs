using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application
{
    public class FormaPagamentoAplicacaoServico : IFormaPagamentoAplicacaoServico
    {
        private readonly IFormaPagamentoServico<FormaPagamento> _servicoFormaPagamento;
        private readonly IMapper _mapper;

        public FormaPagamentoAplicacaoServico(IFormaPagamentoServico<FormaPagamento> servicoFormaPAgamento, IMapper mapper)
        {
            _servicoFormaPagamento = servicoFormaPAgamento;
            _mapper = mapper;
        }

        public FormaPagamentoDto Adicionar(FormaPagamentoDto formaPagamentoDto)
        {
            var dadosFormaPagamento = _servicoFormaPagamento.AdicionarFormaPagamento(_mapper.Map<FormaPagamento>(formaPagamentoDto));
            return _mapper.Map<FormaPagamentoDto>(dadosFormaPagamento);
        }

        public FormaPagamentoDto Atualizar(FormaPagamentoDto formaPagamentoDto)
        {
            var dadosFormaPagamento = _servicoFormaPagamento.AtualizarFormaPagamento(_mapper.Map<FormaPagamento>(formaPagamentoDto));
            return _mapper.Map<FormaPagamentoDto>(dadosFormaPagamento);
        }       

        public IEnumerable<FormaPagamentoDto> BuscarFormasPagamento(int codigoEmpresa)
        => _mapper.Map<IEnumerable<FormaPagamentoDto>>(_servicoFormaPagamento.BuscarFormasPagamento(codigoEmpresa));

        public FormaPagamentoDto BuscarPorCodigo(int id)
       => _mapper.Map<FormaPagamentoDto>(_servicoFormaPagamento.BuscarPorCodigo(id));        

        public void Excluir(FormaPagamentoDto formaPagamentoDto)
        => _servicoFormaPagamento.Excluir(_mapper.Map<FormaPagamento>(formaPagamentoDto));

        
    }
}