// See https://aka.ms/new-console-template for more information
using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Infrastructure.Data.Repositories;

Console.WriteLine("Hello, World!");

var testeData = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
var testeData2 = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local);

var resultado = "";




RepositoryAddress _repoAddress = new RepositoryAddress(new SqlContext());
RepositoryCity _repoCity = new RepositoryCity(new SqlContext());
RepositoryUser _repoUser = new RepositoryUser(new SqlContext());


var city = new City()
{
    Name = "Porto Alegre",
    ZipCode = "1245456465",
    IsActive = true,
    CodeIgbe = "4314902",
    StateCodeIgbe = "43",
    StateSymbol = "RS"


};

_repoCity.Add(city);

var user = new User()
{
    Name = "Tiago",
    LastName = "Buchanelli",
    Email = "tiagobuchanelli@gmail.com",
    DocumentNumber = "014524658",
    IsActive = true,
    Phone = "55996489002",
    Image = "www.imagem.com"
};

_repoUser.Add(user);

var address = new Address()
{
    UserId = user.Id,
    CityId = city.Id,
    Street = "Rua dos Andradas",
    StreetNumber = "150",
    ZipCode = "984587542",
    District = "Centro",
    Complement = "Apto"

};

_repoAddress.Add(address);
