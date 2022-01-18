using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class MovimentacaoProdutoLote : Base
    {
        #region Construtores
        private MovimentacaoProdutoLote()
        {
        }

        public MovimentacaoProdutoLote(
            Lote lote,
            int codigoLancamento,
            int codigoItem,
            Empresa empresa,
            Produto produto,
            OrigemMovimentacaoProduto origemMovimentacaoProduto,
            decimal quantidadeEntrada,
            decimal quantidadeSaida
            )
        {
            CodigoLancamento = codigoLancamento;
            CodigoItem = codigoItem;
            EmpresaId = empresa.Id;
            ProdutoId = produto.Id;
            OrigemMovimentacaoProdutoId = origemMovimentacaoProduto.Id;
            DataLancamento = DateTime.Now;
            QuantidadeEntrada = quantidadeEntrada;
            QuantidadeSaida = quantidadeSaida;
            SaldoAnterior = ObterSaldoAnterior();
            Saldo = CalcularSaldoAtual();
            LoteId = lote.Id;

            Validar();
        }


        #endregion

        #region Atributos Públicos        

        public int CodigoLancamento { get; private set; }

        public int CodigoItem { get; private set; }

        public int EmpresaId { get; private set; }

        public int ProdutoId { get; private set; }

        public int OrigemMovimentacaoProdutoId { get; private set; }

        public int LoteId { get; private set; }

        public Lote Lote { get; private set; }

        public DateTime DataLancamento { get; private set; }

        public decimal QuantidadeEntrada { get; private set; }

        public decimal QuantidadeSaida { get; private set; }

        public decimal SaldoAnterior { get; private set; }

        public decimal Saldo { get; private set; }

        public Empresa Empresa { get; private set; }

        public Produto Produto { get; private set; }

        public OrigemMovimentacaoProduto OrigemMovimentacaoProduto { get; private set; }
        #endregion

        #region Metodos Privados
        private void Validar()
        {
            if (LoteId == default)
                throw new Exception("Obrigatório informar um lote válido");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");

            if (ProdutoId == default)
                throw new Exception("Obrigatório informar um produto válido");

            if (OrigemMovimentacaoProdutoId == default)
                throw new Exception("Obrigatório informar uma origem válida");

        }

        private decimal ObterSaldoAnterior()
        {
            return 0;
        }

        private decimal CalcularSaldoAtual()
        {
            return 0;
        }
        #endregion

        #region Metodos Publicos

        #endregion

    }
}
