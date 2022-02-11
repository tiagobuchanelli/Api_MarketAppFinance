namespace Api_MarketAppFinance.Domain.Entities
{
    public class LicencaAcesso : Base
    {
        #region Constructos

        private LicencaAcesso()
        {
        }

        public LicencaAcesso(string descricao, Licenca licenca, LicencaDispositivo dispositivo, Empresa empresa)
        {
            this.Descricao = descricao;
            this.LicencaId = licenca.Id;
            this.DispositivoId = dispositivo.Id;
            EmpresaId = empresa.Id;
        }

        #endregion Constructos

        #region Actributes Public

        public string Descricao { get; private set; }

        public int LicencaId { get; private set; }

        public int DispositivoId { get; private set; }

        public int EmpresaId { get; private set; }

        public Empresa Empresa { get; private set; }

        public Licenca Licenca { get; private set; }

        public LicencaDispositivo Dispositivo { get; private set; }

        #endregion Actributes Public

        #region Private Methos

        #endregion Private Methos

        #region Metodos Publicos

        public void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");

            if (DispositivoId == default)
                throw new Exception("Obrigatório informar um dispositivo válido");

            if (LicencaId == default)
                throw new Exception("Obrigatório informar uma licença válida");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }


        #endregion
    }
}