namespace Api_MarketAppFinance.Domain.Entities
{
    public class Carteira : Base
    {
        #region Constructos

        private Carteira()
        {
        }

        public Carteira(string desc, int empresaId, string? abreviacao = null, decimal? valorMinimoVenda = null)
        {
            Descricao = desc;
            Abreviacao = abreviacao;
            Ativo = true;
            EmpresaId = empresaId;
            ValorMinimoVenda = valorMinimoVenda ?? 0;            
        }

        #endregion Constructos

        #region Actributes Public

        public string Descricao { get; private set; }

        public string? Abreviacao { get; private set; }

        public bool Ativo { get; private set; }

        public int EmpresaId { get; private set; }

        public decimal ValorMinimoVenda { get; private set; }

        public Empresa Empresa { get; private set; }

        #endregion Actributes Public

        #region Private Methods        

        #endregion Private Methods

        #region Public Methods

        public void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar o nome.");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida.");
        }

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarValorMinimoVenda(decimal valorMinimo)
        {
            if (ValorMinimoVenda < 0)
                throw new Exception("Obrigatório informar o valor minimo venda válido.");

            ValorMinimoVenda = valorMinimo;
        }

        public void AlterarDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new Exception("Obrigatório informar o nome.");

            Descricao = descricao;
        }

        public void AlterarAbreviacao(string abreviacao)
        {
            Abreviacao = abreviacao;
        }

        #endregion Public Methods
    }
}