// See https://aka.ms/new-console-template for more information
using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


RepositoryAddress _repoAddress = new RepositoryAddress(new SqlContext());
RepositoryCity _repoCity = new RepositoryCity(new SqlContext());
RepositoryUser _repoUser = new RepositoryUser(new SqlContext());
RepositoryDevice _repoDevice = new RepositoryDevice(new SqlContext());
RepositoryLicense _repoLicense = new RepositoryLicense(new SqlContext());
RepositoryLicenseAccessControll _repoAccessControll = new RepositoryLicenseAccessControll(new SqlContext());

var dadosUsuario2 = _repoUser.GetById(2);
var deviceUsuario = _repoDevice.GetAll().FirstOrDefault();
var licensadoUsuario2 = _repoLicense.GetAll().Where(x => x.UserId == dadosUsuario2.Id).FirstOrDefault();

var controleDeAcesso = new LicensesAccessControll() { 
    Description = "Adicionado novo acesso",
    LicenseId = licensadoUsuario2.Id,
    DeviceId = deviceUsuario.Id
};

_repoAccessControll.Add(controleDeAcesso);

/*
var licenca = new License() { 
    Key = "XASDASDASYI", 
    Description = "Licença Liberada", 
    Type = "PREMIUM", 
    MaxAcess = 5, 
    ExpirationLicense = DateTime.Now.Date, 
    UserId = 4
};

_repoLicense.Add(licenca);
*/
var teste = "";


/*
var users = _repoUser.GetAll();
var adresses = _repoAddress.GetAll();
var cities = _repoCity.GetAll();

var teste = new SqlContext();
var dadosUsuario2 = _repoUser.GetById(2);
var dadosUsuario2new = _repoUser._context.Users.Where(u => u.Id == 2).Include(e => e.Adresses).ThenInclude(c => c.City).ToList();

var cidadeUsuario2 = "";
*/


/*
var address = new Address()
{
    UserId = 4,
    CityId = 3,
    Street = "Avenida Rio GRande",
    StreetNumber = "150",
    ZipCode = "48787878",
    District = "Centro",
    Complement = "Apto"

};

_repoAddress.Add(address);




var city = new City()
{
    Name = "São Paulo",
    ZipCode = "48878545",
    IsActive = true,
    CodeIgbe = "3550308",
    StateCodeIgbe = "35",
    StateSymbol = "SP"


};

_repoCity.Add(city);


var user = new User()
{
    Name = "Felipe",
    LastName = "Alves",
    Email = "felipe@gmail.com",
    DocumentNumber = "9854874",
    IsActive = true,
    Phone = "5599999998",
    Image = "www.imagem.com"
};


_repoUser.Add(user);

*/
