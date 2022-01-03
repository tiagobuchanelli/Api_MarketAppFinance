// See https://aka.ms/new-console-template for more information
using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Infrastructure.Data.Repositories;
using Api_MarketAppFinance.Test;

Console.WriteLine("Hello, World!");

var repoTeste = new FunctionsTest();
var cidades =repoTeste.GetCidades();
var enderecos = repoTeste.GetEnderecos();
var usuarios = repoTeste.GetUsuarios();
var dispositovos = repoTeste.GetDevices();
var licencas = repoTeste.GetLicenses();
var acessControllLicense = repoTeste.GetLicensesAcessControll();
var empresas = repoTeste.GetEmpresas();

var teste = "";
/*
    Testes
    -   Criar Usuario
    -   Criar Dispositivos
    -   Criar Empresa
    -   Criar Licença Empresa
    -   Criar Controle de Acesso Licença
    -   Criar Endereços Usuários
 
*/ 