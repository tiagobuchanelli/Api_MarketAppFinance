using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Api_MarketAppFinance.Test
{    
    public class FunctionsTest
    {
        EnderecoRepositorio _repoAddress = new EnderecoRepositorio(new ContextoBase());
        CidadeRepositorio _repoCity = new CidadeRepositorio(new ContextoBase());
        UsuarioRepositorio _repoUser = new UsuarioRepositorio(new ContextoBase());
        EmpresaRepositorio _repoCompany = new EmpresaRepositorio(new ContextoBase());
        Dispositvo _repoDevice = new Dispositvo(new ContextoBase());
        LicencaRepositorio _repoLicense = new LicencaRepositorio(new ContextoBase());
        LicensaDispositivoRepositorio _repoAccessControll = new LicensaDispositivoRepositorio(new ContextoBase());

        public IEnumerable<Usuario> GetUsuarios()
        => _repoUser.GetAll();

        public IEnumerable<Cidade> GetCidades()
        => _repoCity.GetAll();

        public IEnumerable<Endereco> GetEnderecos()
        => _repoAddress.GetAll();

        public IEnumerable<LicencaDispositivo> GetDevices()
        => _repoDevice.GetAll();

        public IEnumerable<Licenca> GetLicenses()
        => _repoLicense.GetAll();
        
        public IEnumerable<LicencaAcesso> GetLicensesAcessControll()
        => _repoAccessControll.GetAll();

        public IEnumerable<Empresa> GetEmpresas()
       => _repoCompany.GetAll();

        /*
        public void teste() {
        _repoLicense._context.Licenses.Include()

        }*/

        
    }

   

}
