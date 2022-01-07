namespace Api_MarketAppFinance.Domain.Entities
{
    public class LicensesAccessControll : Base
    {
        #region Constructos
        private LicensesAccessControll()
        {
        }

        public LicensesAccessControll(string description, License license, Device device)
        {
            this.Description = description;
            this.LicenseId = license.Id;
            this.DeviceId = device.Id;

            Validate();
        }
        #endregion

        #region Actributes Public
        public string Description { get; private set; }

        public int LicenseId { get; private set; }

        public int DeviceId { get; private set; }

        public License License { get; private set; }

        public Device Device { get; private set; }
        #endregion

        #region Private Methos
        private void Validate()
        {
            if (string.IsNullOrEmpty(Description))
                throw new Exception("Obrigatório informar a descrição.");
        }
        #endregion

    }
}