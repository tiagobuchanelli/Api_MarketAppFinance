using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class ContaAPagarParcela : Base
    {
        #region Construtores

        private ContaAPagarParcela()
        {
        }

        public ContaAPagarParcela(
            int numeroParcela,
            decimal valorParcela,
            DateTime dataVencimento,
            ContaAPagar contaAPagar,
            Empresa empresa,
            FormaPagamento formaPagamento,
            decimal? valorAcrescimo = null,
            decimal? valorDesconto = null,
            string? observacao = null,
            DateTime? dataPagamento = null)
        {
            EmpresaId = empresa.Id;
            NumeroParcela = numeroParcela;
            ValorParcela = valorParcela;
            ValorAcrescimo = valorAcrescimo ?? 0;
            ValorDesconto = valorDesconto ?? 0;
            Observacao = observacao;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            ContaAPagarId = contaAPagar.Id;
            FormaPagamentoId = formaPagamento.Id;
        }

        #endregion Construtores

        #region Atributos Publicos

        public int ContaAPagarId { get; private set; }

        public int FormaPagamentoId { get; private set; }

        public int NumeroParcela { get; private set; }

        public decimal ValorParcela { get; private set; }

        public decimal ValorSaldo { get; private set; }

        public decimal ValorAcrescimo { get; private set; }

        public decimal ValorDesconto { get; private set; }

        public string? Observacao { get; private set; }

        public DateTime DataVencimento { get; private set; }

        public DateTime? DataPagamento { get; private set; }

        public int EmpresaId { get; private set; }

        public Empresa Empresa { get; private set; }

        public ContaAPagar ContaAPagar { get; private set; }

        public FormaPagamento FormaPagamento { get; private set; }

        #endregion Atributos Publicos

        #region Metodos Privados

        #endregion Metodos Privados

        #region Metodos Publicos

        public void Validar()
        {
            if (NumeroParcela <= 0)
                throw new Exception("Obrigatório informar um número de parcela válido");

            if (ValorParcela <= 0)
                throw new Exception("Obrigatório informar um valor de parcela válido");

            if (DataVencimento <= DateTime.Now)
                throw new Exception("Obrigatório informar uma data de vencimento maior que a data atual.");

            if (ContaAPagarId == default)
                throw new Exception("Obrigatório informar uma conta a pagar válida.");

            if (FormaPagamentoId == default)
                throw new Exception("Obrigatório informar uma forma de pagamento válida.");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }               

        public void AlterarValorSaldo(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("Obrigatório informar um valor válido");

            ValorSaldo = valor;
        }

        #endregion Metodos Publicos
    }
}