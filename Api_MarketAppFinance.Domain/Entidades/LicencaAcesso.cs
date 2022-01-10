namespace Api_MarketAppFinance.Domain.Entities
{
    public class LicencaAcesso : Base
    {
        #region Constructos
        private LicencaAcesso()
        {
        }

        public LicencaAcesso(string description, Licenca license, LicencaDispositivo device)
        {
            this.Descricao = description;
            this.LicencaId = license.Id;
            this.DispositivoId = device.Id;

            Validar();
        }
        #endregion

        #region Actributes Public
        public string Descricao { get; private set; }

        public int LicencaId { get; private set; }

        public int DispositivoId { get; private set; }

        public Licenca Licenca { get; private set; }

        public LicencaDispositivo Dispositivo { get; private set; }
        #endregion

        #region Private Methos
        private void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");
        }
        #endregion

    }
}