namespace Api_MarketAppFinance.Domain.Entities
{
    public class Company : Base
    {
        #region Constructos

        private Company()
        { }

        public Company(string name, string shortName, string? phone, User user)
        {
            Name = name;
            ShortName = shortName;
            Phone = phone;
            UserId = user.Id;

            _licenses = new List<License>();

            Valdidate();
        }

        #endregion Constructos

        #region Actributes Private

        private IList<License> _licenses;

        #endregion

        #region Actributes Public

        public string Name { get; private set; }

        public string ShortName { get; private set; }

        public bool IsActive { get; private set; }

        public string? Phone { get; private set; }

        public string? Image { get; private set; }

        public int UserId { get; private set; }

        public User User { get; private set; }

        public IReadOnlyCollection<License> Licenses { get { return _licenses.ToList(); } }

        #endregion Actributes

        #region Private Methods

        private void Valdidate()
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Obrigatório informar o nome da empresa.");

            if(string.IsNullOrEmpty(ShortName))
                throw new Exception("Obrigatório informar o nome curto da empresa.");

            if (UserId == default)
                throw new Exception("Obrigatório informar um usuário valido");
        }

        #endregion Private Methods

        #region Public Methods

        public void SetCompanyImage(string imageCompany) => Image = imageCompany;

        public void SetCompanyPhone(string phone) => Phone = phone;

        public void SetCompanyStatusActive() => IsActive = true;

        public void SetCompanyStatusInactive() => IsActive = true;

        public void GenerateLicense(License license)
        {            
            _licenses.Add(license);
        }

        #endregion Public Methods
    }
}