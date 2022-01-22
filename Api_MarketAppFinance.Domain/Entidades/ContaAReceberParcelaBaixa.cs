using Api_MarketAppFinance.Domain.Entidades;

namespace Api_MarketAppFinance.Domain.Entities
{
    public class ContaAReceberParcelaBaixa : Base
    {
        #region Constructos
        private ContaAReceberParcelaBaixa()
        {
        }

        public ContaAReceberParcelaBaixa(
            Empresa empresa, 
            ContaAReceber contaAReceber, 
            FormaPagamento formaPagamento, 
            DateTime dataPagamento, 
            decimal valorPagamento, 
            decimal? valorAcrescimo = null, 
            decimal? valorDesconto = null, 
            string? observacao = null)
        {
            EmpresaId = empresa.Id;
            ContaAReceberId = contaAReceber.Id;
            FormaPagamentoId = formaPagamento.Id;
            DataPagamento = dataPagamento;
            ValorPagamento = valorPagamento;
            ValorAcrescimo = valorAcrescimo ?? 0;
            ValorDesconto = valorDesconto ?? 0;
            Observacao = observacao;
        }
        #endregion

        #region Actributes Public
        
        public int EmpresaId { get; private set; }
        
        public int ContaAReceberId { get; private set; }  
        
        public int FormaPagamentoId { get; private set; }  
        
        public DateTime DataPagamento { get; private set; }   
        
        public decimal ValorPagamento { get; private set; }       
        
        public decimal ValorAcrescimo { get; private set; }       
        
        public decimal ValorDesconto { get; private set; }   
        
        public string? Observacao { get; private set; }       

        public Empresa Empresa { get; private set; }

        public ContaAReceber ContaAReceber { get; private set; }

        public FormaPagamento FormaPagamento { get; private set; }
        #endregion

        #region Private Methods
        private void Validar()
        {
            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida.");

            if (ContaAReceberId == default)
                throw new Exception("Obrigatório informar uma conta válida.");

            if (FormaPagamentoId == default)
                throw new Exception("Obrigatório informar uma forma de pagamento válida.");

            if (ValorPagamento <= 0)
                throw new Exception("Obrigatório informar um valor válido.");

        }
        #endregion

        #region Public Methods
        
        #endregion

       
    }
}