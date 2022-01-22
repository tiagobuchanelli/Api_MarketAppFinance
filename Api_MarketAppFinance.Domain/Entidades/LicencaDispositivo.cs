namespace Api_MarketAppFinance.Domain.Entities
{
    public class LicencaDispositivo : Base
    {
        #region Constructos
        private LicencaDispositivo()
        {
        }

        public LicencaDispositivo(string nome, string chave, Usuario usuario, Empresa empresa)
        {
            this.Nome = nome;
            this.Chave = chave;
           this.UsuarioId = usuario.Id;
            EmpresaId = empresa.Id;

            Validar();
        }

        #endregion

        #region Actributes Public
        public string Nome { get; private set; }

        public string Chave { get; private set; }

        public int UsuarioId { get; private set; }

        public int EmpresaId { get; private set; }

        public Empresa Empresa { get; private set; }

        public Usuario Usuario { get; private set; }
        #endregion

        #region Private Methods
        private void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Obrigatório informar o nome do dispositivo.");

            if (string.IsNullOrEmpty(Chave))
                throw new Exception("Obrigatório informar a chave do dispositivo.");

            if (UsuarioId == default)
                throw new Exception("Obrigatório informar um usuário válido.");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }
        #endregion

        #region Public Methods
        public void AlterarNome(string nameDevice) 
        {
            if (string.IsNullOrEmpty(nameDevice))
                throw new Exception("Obrigatório informar um nome de dispositivo.");
            Nome = nameDevice; 
        }
        #endregion
    }
}