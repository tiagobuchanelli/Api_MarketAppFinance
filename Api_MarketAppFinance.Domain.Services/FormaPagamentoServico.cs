using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;

namespace Api_MarketAppFinance.Domain.Services
{
    public class FormaPagamentoServico : ServicoBase<FormaPagamento>, IFormaPagamentoServico<FormaPagamento>
    {
        private readonly IFormaPagamentoRepositorio<FormaPagamento> _formaPagamentoRepositorio;

        public FormaPagamentoServico(IFormaPagamentoRepositorio<FormaPagamento> formaPagamentoRepositorio) : base(formaPagamentoRepositorio)
        {
            this._formaPagamentoRepositorio = formaPagamentoRepositorio;
        }

        #region Metodos Privados
        
        #endregion       

        public FormaPagamento AdicionarFormaPagamento(FormaPagamento dadosFormaPagamento)
        {
            dadosFormaPagamento.Validar();

            Adicionar(dadosFormaPagamento);
            return BuscarFormasPagamento(dadosFormaPagamento.EmpresaId).Last();
        }
              

        public FormaPagamento AtualizarFormaPagamento(FormaPagamento dados)
        {
            var formaPagamento = BuscarPorCodigo(dados.EmpresaId, dados.Id);

            if(formaPagamento is not null)
            {
                formaPagamento.AlterarDescricao(dados.Descricao);
                formaPagamento.AlterarTipoPagamento(dados.TipoPagamento);
                formaPagamento.AlterarCarteira(dados.Carteira);
                formaPagamento.AlterarAbreviacao(dados.Abreviacao);
                formaPagamento.AlterarValorAcrescimo(dados.ValorAcrescimo);
                formaPagamento.AlterarValorDesconto(dados.ValorDesconto);
                formaPagamento.AlterarPrDesconto(dados.PrDesconto);
                formaPagamento.AlterarPrAcrescimo(dados.PrAcrescimo);
                formaPagamento.AlterarNrDiasIntervalo(dados.NrDiasIntervalo);
                formaPagamento.AlterarNrDiasLimiteIntervalo(dados.NrDiasLimiteIntervalo);
                formaPagamento.AlterarNrIntervalos(dados.NrIntervalos);
                formaPagamento.AlterarDiaPadraoVencimento(dados.DiaPadraoVencimento);
                formaPagamento.AlterarGerarFinanceiro(dados.GerarFinanceiro);

                Atualizar(formaPagamento);                

            }

            return formaPagamento;

        }       

        public List<FormaPagamento> BuscarFormasPagamento(int codigoEmpresa)
        => _formaPagamentoRepositorio.BuscarFormasPagamento(codigoEmpresa);

        public FormaPagamento BuscarPorCodigo(int codigoEmpresa, int codigo)
        => _formaPagamentoRepositorio.BuscarPorCodigo(codigoEmpresa, codigo);
    }
}