// See https://aka.ms/new-console-template for more information
using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Infrastructure.Data.Repositories;
using Api_MarketAppFinance.Test;
using Microsoft.EntityFrameworkCore;


Console.WriteLine("Hello, World!");

/*pesquisas 
RepositoryLicense _repoLicense = new RepositoryLicense(new SqlContext());
RepositoryUser _repoUser = new RepositoryUser(new SqlContext());
RepositoryCompany _repoCompany = new RepositoryCompany(new SqlContext());


var repoTeste = new FunctionsTest();
var usuarios = repoTeste.GetUsuarios();

var cidades = repoTeste.GetCidades();
var enderecos = repoTeste.GetEnderecos();

var dispositovos = repoTeste.GetDevices();
var licencas = repoTeste.GetLicenses();
var licencasComDetalhesEmpresa = _repoLicense._context.Licenses.Include(x => x.Company).ToList();

var acessControllLicense = repoTeste.GetLicensesAcessControll();
//var empresas = repoTeste.GetEmpresas();
var empresa = repoTeste.GetEmpresas().Where(x => x.Id == 4).First();

var empresasComDetalhesLicencas = _repoCompany._context.Companies.Include(x => x.Licenses).ToList();


var usuario = usuarios.Where(x => x.Id == 2).First();
*/

var teste = "";


/*adicionar empresa manualmente
 var empresaStart = new Company("Star Link2", "Star Link Software2", "4454545", usuario);
_repoCompany.Add(empresaStart);
*/

/*adicionar licença manualmente
 var licenca = new License("Licença de Software", "PREMIUM", 2, DateTime.Now.AddMonths(5).Date, empresa);
_repoLicense.Add(licenca);
*/

/*adicionar licença a empresa criada no mesmo momento que alicença
var empresaTeste = new Company("Star Link", "Star Link Software", "4454545", usuario);
var licencaEmpresaTeste = new License("Licença de Software", "PREMIUM", 4, DateTime.Now.AddMonths(3).Date, empresaTeste);
empresaTeste.GenerateLicense(licencaEmpresaTeste);
_repoCompany.Update(empresaTeste);
*/

/*alterar adicionar licença a empresa ja existente e com licença ativa
var empresas4 = _repoCompany._context.Companies.Include(x => x.Licenses).Where(x => x.Id == 4).First();
var licencaEmpresaTeste = new License("Licença de Software", "PREMIUM", 9, DateTime.Now.AddMonths(1).Date, empresas4);
empresas4.GenerateLicense(licencaEmpresaTeste);
_repoCompany.Update(empresas4);
*/

var teste23 = "";






