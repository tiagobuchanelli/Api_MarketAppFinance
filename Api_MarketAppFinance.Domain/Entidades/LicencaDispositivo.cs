namespace Api_MarketAppFinance.Domain.Entities
{
    public class LicencaDispositivo : Base
    {
        #region Constructos
        private LicencaDispositivo()
        {
        }

        public LicencaDispositivo(string name, string key, Usuario user)
        {
            this.Nome = name;
            this.Chave = key;
           this.UsuarioId = user.Id;

            Validar();
        }

        #endregion

        #region Actributes Public
        public string Nome { get; private set; }

        public string Chave { get; private set; }

        public int UsuarioId { get; private set; }

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