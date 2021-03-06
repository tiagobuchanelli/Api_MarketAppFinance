using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class VendaParcela : Base
    {
        #region Construtores

        private VendaParcela()
        {
        }

        public VendaParcela(
            int numeroParcela,
            DateTime dataVencimento,
            decimal valorParcela,
            Venda venda,
             Empresa empresa,
            VendaFormaPagamento vendaFormaPagamento
            )
        {
            VendaId = venda.Id;
            VendaFormaPagamentoId = vendaFormaPagamento.Id;
            NumeroParcela = numeroParcela;
            DataVencimento = dataVencimento;
            ValorParcela = valorParcela;
            EmpresaId = empresa.Id;
        }

        #endregion Construtores

        #region Atributos Publicos

        public int VendaId { get; private set; }

        public int VendaFormaPagamentoId { get; private set; }

        public int NumeroParcela { get; private set; }

        public DateTime DataVencimento { get; private set; }

        public decimal ValorParcela { get; private set; }

        public int EmpresaId { get; private set; }

        public Empresa Empresa { get; private set; }

        public Venda Venda { get; private set; }

        public VendaFormaPagamento VendaFormaPagamento { get; private set; }

        #endregion Atributos Publicos

        #region Metodos Privados

        #endregion Metodos Privados

        #region Metodos Publicos

        public void Validar()
        {
            if (VendaId == default)
                throw new Exception("Obrigatório informar uma venda válida");

            if (VendaFormaPagamentoId == default)
                throw new Exception("Obrigatório informar uma forma de pagamento válida");

            if (NumeroParcela <= 0)
                throw new Exception("Obrigatório informar um número de parcela válido");

            if (ValorParcela <= 0)
                throw new Exception("Obrigatório informar um valor válido");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }

        #endregion
    }
}