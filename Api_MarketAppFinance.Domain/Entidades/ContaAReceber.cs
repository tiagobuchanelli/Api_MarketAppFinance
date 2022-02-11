using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class ContaAReceber : Base
    {
        #region Construtores

        private ContaAReceber()
        {
        }

        public ContaAReceber(
            int codigoLancamentoId,
            decimal numeroDocumento,
            decimal valorTotal,
            bool ativo,
            Empresa empresa,
            Carteira carteira,
            FormaPagamento formaPagamento,
            Cliente cliente,
            string? observacao = null)
        {
            EmpresaId = empresa.Id;
            CodigoLancamentoId = codigoLancamentoId;
            CarteiraId = carteira.Id;
            FormaPagamentoId = formaPagamento.Id;
            NumeroDocumento = numeroDocumento;
            ValorTotal = valorTotal;
            Observacao = observacao;
            Ativo = ativo;
            ClienteId = cliente.Id;
        }

        #endregion Construtores

        #region Atributos Publicos

        public int EmpresaId { get; private set; }

        public int CodigoLancamentoId { get; private set; }

        public int CarteiraId { get; private set; }

        public int ClienteId { get; private set; }

        public int FormaPagamentoId { get; private set; }

        public decimal NumeroDocumento { get; private set; }

        public decimal ValorTotal { get; private set; }

        public string? Observacao { get; private set; }

        public bool Ativo { get; private set; }

        public Empresa Empresa { get; private set; }

        public Cliente Cliente { get; private set; }

        public Carteira Carteira { get; private set; }

        public FormaPagamento FormaPagamento { get; private set; }

        #endregion Atributos Publicos

        #region Metodos Privados
        #endregion Metodos Privados

        #region Metodos Publicos

        public void Validar()
        {
            /*if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");

            if (CategoriaId == default)
                throw new Exception("Obrigatório informar uma categoria válida");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
            */
        }        

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        #endregion Metodos Publicos
    }
}