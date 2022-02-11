using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class ContaAPagar : Base
    {
        #region Construtores

        private ContaAPagar()
        {
        }

        public ContaAPagar(
            int codigoLancamentoId,
            decimal numeroDocumento,
            decimal valorTotal,
            bool ativo,
            Empresa empresa,
            Carteira carteira,
            FormaPagamento formaPagamento,
            Fornecedor fornecedor,
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
            FornecedorId = fornecedor.Id;
        }

        #endregion Construtores

        #region Atributos Publicos

        public int EmpresaId { get; private set; }

        public int CodigoLancamentoId { get; private set; }

        public int CarteiraId { get; private set; }

        public int FormaPagamentoId { get; private set; }

        public int FornecedorId { get; private set; }

        public decimal NumeroDocumento { get; private set; }

        public decimal ValorTotal { get; private set; }

        public string? Observacao { get; private set; }

        public bool Ativo { get; private set; }

        public Empresa Empresa { get; private set; }

        public Carteira Carteira { get; private set; }

        public FormaPagamento FormaPagamento { get; private set; }

        public Fornecedor Fornecedor { get; private set; }

        #endregion Atributos Publicos

        #region Metodos Privados

        #endregion Metodos Privados

        #region Metodos Publicos

        public void Validar()
        {
            if (CodigoLancamentoId <= 0)
                throw new Exception("Obrigatório informar um lançamento válido");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");

            if (CarteiraId == default)
                throw new Exception("Obrigatório informar uma carteira válida");

            if (FormaPagamentoId == default)
                throw new Exception("Obrigatório informar uma forma de pagamento válida");

            if (FornecedorId == default)
                throw new Exception("Obrigatório informar um fornecedor válido");
        }        

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        #endregion Metodos Publicos
    }
}