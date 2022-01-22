namespace Api_MarketAppFinance.Domain.Entities
{
    public class Carteira : Base
    {
        #region Constructos
        private Carteira()
        {
        }

        public Carteira(string desc, Empresa empresa,string? abreviacao = null)
        {
            Descricao = desc;
            Abreviacao = abreviacao;            
            Ativo = true;
            EmpresaId = empresa.Id;

            Validar();
        }        

        #endregion

        #region Actributes Public
        public string Descricao { get; private set; }

        public string? Abreviacao { get; private set; }

        public bool Ativo { get; private set; }

        public int EmpresaId { get; private set; }

        public decimal ValorMinimoVenda { get; private set; }

        public Empresa Empresa { get; private set; }
        #endregion

        #region Private Methods
        private void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar o nome.");            

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida.");

        }
        #endregion

        #region Public Methods
        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarValorMinimoVenda(decimal valorMinimo)
        {
            if (ValorMinimoVenda <= 0)
                throw new Exception("Obrigatório informar o valor minimo venda válido.");

            ValorMinimoVenda = valorMinimo;
        }
        #endregion

       
    }
}