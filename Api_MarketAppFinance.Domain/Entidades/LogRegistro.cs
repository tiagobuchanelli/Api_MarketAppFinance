namespace Api_MarketAppFinance.Domain.Entities
{
    public class LogRegistro : Base
    {
        #region Constructos

        private LogRegistro()
        {
        }

        public LogRegistro(
            Empresa empresa,
            string tabela,
            int chaveTabela,
            Usuario usuario,
            string valorAnterior,
            string valorAtual)
        {
            EmpresaId = empresa.Id;
            Tabela = tabela;
            ChaveTabela = chaveTabela;
            UsuarioId = usuario.Id;
            ValorAnterior = valorAnterior;
            ValorAtual = valorAtual;

            Validar();
        }

        #endregion Constructos

        #region Actributes Public

        public int EmpresaId { get; private set; }

        public string Tabela { get; private set; }

        public int ChaveTabela { get; private set; }

        public int UsuarioId { get; private set; }

        public string ValorAnterior { get; private set; }

        public string ValorAtual { get; private set; }

        public Empresa Empresa { get; private set; }

        public Usuario Usuario { get; private set; }

        #endregion Actributes Public

        #region Private Methods

        private void Validar()
        {
            if (string.IsNullOrEmpty(Tabela))
                throw new Exception("Obrigatório informar a tabela.");

            if (ChaveTabela <= 0)
                throw new Exception("Obrigatório informar uma chave de tabela válida");

            if (string.IsNullOrEmpty(ValorAnterior))
                throw new Exception("Obrigatório informar o valor anterior.");

            if (string.IsNullOrEmpty(ValorAtual))
                throw new Exception("Obrigatório informar o valor atual.");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");

            if (UsuarioId == default)
                throw new Exception("Obrigatório informar um usuário válido");
        }

        #endregion Private Methods
    }
}