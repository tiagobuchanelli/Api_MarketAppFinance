namespace Api_MarketAppFinance.Domain.Entities
{
    public class Device : Base
    {
        #region Constructos
        private Device()
        {
        }

        public Device(string name, string key, User user)
        {
            this.Name = name;
            this.Key = key;
           this.UserId = user.Id;

            Validate();
        }

        #endregion

        #region Actributes Public
        public string Name { get; private set; }

        public string Key { get; private set; }

        public int UserId { get; private set; }

        public User User { get; private set; }
        #endregion

        #region Private Methods
        private void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Obrigatório informar o nome do dispositivo.");

            if (string.IsNullOrEmpty(Key))
                throw new Exception("Obrigatório informar a chave do dispositivo.");

            if (UserId == default)
                throw new Exception("Obrigatório informar um usuário válido.");
        }
        #endregion

        #region Public Methods
        public void SetNameDevice(string nameDevice) => Name = nameDevice;
        #endregion
    }
}