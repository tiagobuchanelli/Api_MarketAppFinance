namespace Api_MarketAppFinance.Domain.Entities
{
    public class User : Base
    {
        #region Constructos
        private User()
        {
        }

        public User(string name, string lastName, string email, string docNumber, string phone, string image)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.DocumentNumber = docNumber;
            this.Image = image;

            _devices = new List<Device>();
            _adresses = new List<Address>();

            Validate();
        }

        

        #endregion

        #region Actributes Private

        private IList<Device> _devices;
        private IList<Address> _adresses;

        #endregion

        #region Actributes Public
        public string Name { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public string? DocumentNumber { get; private set; }

        public bool IsActive { get; private set; }

        public string? Phone { get; private set; }

        public string? Image { get; private set; }        

        public IEnumerable<Address> Adresses { get { return _adresses.ToList(); } }

        public IEnumerable<Device> Devices { get { return _devices.ToList(); } }
        #endregion

        #region Private Method
        private void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Obrigatório informar o nome do usuário.");

            if (string.IsNullOrEmpty(LastName))
                throw new Exception("Obrigatório informar o sobre nome.");

            if (string.IsNullOrEmpty(Email))
                throw new Exception("Obrigatório informar o e-mail.");

        }
        #endregion

        #region Public Methods
        public void GenerateAddress(Address address)
        {
            _adresses.Add(address);
        }

        public void GenerateDevice(Device device)
        {
            _devices.Add(device);
        }
        #endregion



    }
}