using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class VendaFormaPagamento : Base
    {
        #region Construtores

        private VendaFormaPagamento()
        {
        }

        public VendaFormaPagamento(
            decimal valor,
            Venda venda,
            Carteira carteira,
            FormaPagamento formaPagamento,
            Empresa empresa)
        {
            EmpresaId = empresa.Id;
            VendaId = venda.Id;
            CarteiraId = carteira.Id;
            FormaPagamentoId = formaPagamento.Id;
            Valor = valor;
        }

        #endregion Construtores

        #region Atributos Publicos

        public int VendaId { get; private set; }

        public int CarteiraId { get; private set; }

        public int FormaPagamentoId { get; private set; }

        public decimal Valor { get; private set; }

        public int EmpresaId { get; private set; }

        public Empresa Empresa { get; private set; }

        public Venda Venda { get; private set; }

        public Carteira Carteira { get; private set; }

        public FormaPagamento FormaPagamento { get; private set; }

        #endregion Atributos Publicos

        #region Metodos Privados

        #endregion Metodos Privados

        #region Metodos Publicos

        public void Validar()
        {
            if (VendaId == default)
                throw new Exception("Obrigatório informar uma venda válida");

            if (CarteiraId == default)
                throw new Exception("Obrigatório informar uma carteira válida");

            if (FormaPagamentoId == default)
                throw new Exception("Obrigatório informar uma forma de pagamento válida");

            if (Valor <= 0)
                throw new Exception("Obrigatório informar um valor válido");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }

        #endregion
    }
}