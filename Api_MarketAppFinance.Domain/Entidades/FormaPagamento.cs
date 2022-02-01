using Api_MarketAppFinance.Domain.Enum;

namespace Api_MarketAppFinance.Domain.Entities
{
    public class FormaPagamento : Base
    {
        #region Constructos

        private FormaPagamento()
        {
        }

        public FormaPagamento(
            string desc,
            Empresa empresa,
            TipoPagamento tipoPagamento,
            Carteira carteira,
            string? abreviacao = null,
            decimal? valorAcrescimo = null,
            decimal? valorDesconto = null,
            decimal? prDesconto = null,
            decimal? prAcrescimo = null,
            decimal? nrDiasIntervalo = null,
            decimal? nrDiasLimiteIntervalo = null,
            decimal? nrIntervalos = null,
            int? diaPadraoVencimento = null,
            bool? gerarFinanceiro = null
            )
        {
            Descricao = desc;
            Abreviacao = abreviacao;
            Ativo = true;
            EmpresaId = empresa.Id;
            TipoPagamento = tipoPagamento;
            CarteiraId = carteira.Id;
            ValorAcrescimo = valorAcrescimo ?? 0;
            ValorDesconto = valorDesconto ?? 0;
            PrDesconto = prDesconto ?? 0;
            PrAcrescimo = prAcrescimo ?? 0;
            NrDiasIntervalo = nrDiasIntervalo ?? 0;
            NrDiasLimiteIntervalo = nrDiasLimiteIntervalo ?? 0;
            NrIntervalos = nrIntervalos ?? 0;
            DiaPadraoVencimento = diaPadraoVencimento ?? 0;
            GerarFinanceiro = gerarFinanceiro ?? false;

            Validar();
        }

        #endregion Constructos

        #region Actributes Public

        public string Descricao { get; private set; }

        public string? Abreviacao { get; private set; }

        public bool Ativo { get; private set; }

        public int EmpresaId { get; private set; }

        public int CarteiraId { get; private set; }

        public TipoPagamento TipoPagamento { get; private set; }

        public decimal ValorAcrescimo { get; private set; }

        public decimal ValorDesconto { get; private set; }

        public decimal PrDesconto { get; private set; }

        public decimal PrAcrescimo { get; private set; }

        public decimal NrDiasIntervalo { get; private set; }

        public decimal NrDiasLimiteIntervalo { get; private set; }

        public decimal NrIntervalos { get; private set; }

        public int DiaPadraoVencimento { get; private set; }

        public bool GerarFinanceiro { get; private set; }

        public Carteira Carteira { get; private set; }

        public Empresa Empresa { get; private set; }

        #endregion Actributes Public

        #region Private Methods

        private void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar o nome.");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida.");

            if (CarteiraId == default)
                throw new Exception("Obrigatório informar uma carteira válida.");
        }

        #endregion Private Methods

        #region Public Methods

        public void AlterarStatus(bool status) => Ativo = status;

        public void AlterarGerarFinanceiro(bool status) => GerarFinanceiro = status;

        public void AlterarValorAcrescimo(decimal valor)
        {
            if (ValorAcrescimo < 0)
                throw new Exception("Obrigatório informar o valor válido.");

            ValorAcrescimo = valor;
        }

        public void AlterarValorDesconto(decimal valor)
        {
            if (ValorDesconto < 0)
                throw new Exception("Obrigatório informar o valor válido.");

            ValorDesconto = valor;
        }

        public void AlterarPrDesconto(decimal percentual)
        {
            if (PrDesconto < 0)
                throw new Exception("Obrigatório informar o percentual válido.");

            PrDesconto = percentual;
        }

        public void AlterarPrAcrescimo(decimal percentual)
        {
            if (PrAcrescimo < 0)
                throw new Exception("Obrigatório informar o percentual válido.");

            PrAcrescimo = percentual;
        }

        public void AlterarNrDiasIntervalo(decimal dias)
        {
            if (NrDiasIntervalo < 0)
                throw new Exception("Obrigatório informar o valor válido.");

            NrDiasIntervalo = dias;
        }

        public void AlterarNrDiasLimiteIntervalo(decimal diasLimiteIntervalo)
        {
            if (NrDiasLimiteIntervalo < 0)
                throw new Exception("Obrigatório informar o valor válido.");

            NrDiasLimiteIntervalo = diasLimiteIntervalo;
        }

        public void AlterarNrIntervalos(decimal numeroIntervalos)
        {
            if (NrIntervalos < 0)
                throw new Exception("Obrigatório informar o valor válido.");

            NrIntervalos = numeroIntervalos;
        }

        public void AlterarDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new Exception("Obrigatório informar a descrição.");

            Descricao = descricao;
        }

        public void AlterarAbreviacao(string abreviacao)
        {
            Abreviacao = abreviacao;
        }

        public void AlterarTipoPagamento(TipoPagamento tipoPagamento)
        {
            if (tipoPagamento < 0)
                throw new Exception("Obrigatório informar o tipo pagamento válido.");

            TipoPagamento = tipoPagamento;
        }

        public void AlterarCarteira(Carteira carteira)
        {
            if (carteira is null)
                throw new Exception("Obrigatório informar uma carteira válida.");

            CarteiraId = carteira.Id;
        }

        public void AlterarDiaPadraoVencimento(int diaPadrao)
        {
            if (DiaPadraoVencimento < 0)
                throw new Exception("Obrigatório informar o valor válido.");

            DiaPadraoVencimento = diaPadrao;
        }

        #endregion Public Methods
    }
}