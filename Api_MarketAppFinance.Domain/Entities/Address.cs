namespace Api_MarketAppFinance.Domain.Entities
{
    public class Address : Base
    {
        #region Constructos
        private Address()
        {
        }

        public Address(string street, string streetNumber, string zipCode, string district, string complement, User user, City city)
        {
            this.Street = street;
            this.StreetNumber = streetNumber;   
            this.ZipCode = zipCode;  
            this.District = district;
            this.Complement = complement;
            this.UserId = user.Id;
            this.CityId = city.Id;

            Validate();

        }

        #endregion

        #region Actributes Public

        public int UserId { get; private set; }

        public int CityId { get; private set; }

        public string Street { get; private set; }

        public string? StreetNumber { get; private set; }

        public string? ZipCode { get; private set; }

        public string? District { get; private set; }

        public string? Complement { get; private set; }

        public User User { get; private set; }

        public City City { get; private set; }

        #endregion

        #region Private Methods
        private void Validate()
        {
            if(string.IsNullOrEmpty(Street))
                throw new Exception("Obrigatório informar a rua.");

            if (UserId == default)
                throw new Exception("Obrigatório informar um usuário válido");

            if(CityId == default)
                throw new Exception("Obrigatório informar um usuário válido");

        }
        #endregion

        #region Public Methods
        public void SetStreet(string street) => Street = street;
        public void SetStreetNumber(string streetNumber) => StreetNumber = streetNumber;
        public void SetZipcode(string zipCode) => ZipCode = zipCode;
        public void SetDistrict(string district) => District = district;
        public void SetComplement(string complement) => Complement = complement;
        #endregion
    }
}