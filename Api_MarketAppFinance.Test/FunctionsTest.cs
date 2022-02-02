using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Infrastructure.Data.Repositories;

namespace Api_MarketAppFinance.Test
{
    public class FunctionsTest
    {
        private EnderecoRepositorio _repoAddress = new EnderecoRepositorio(new ContextoBase());
        private CidadeRepositorio _repoCity = new CidadeRepositorio(new ContextoBase());
        private UsuarioRepositorio _repoUser = new UsuarioRepositorio(new ContextoBase());
        private EmpresaRepositorio _repoCompany = new EmpresaRepositorio(new ContextoBase());
        private Dispositvo _repoDevice = new Dispositvo(new ContextoBase());
        private LicencaRepositorio _repoLicense = new LicencaRepositorio(new ContextoBase());
        private LicensaDispositivoRepositorio _repoAccessControll = new LicensaDispositivoRepositorio(new ContextoBase());
        /*
        public IEnumerable<Usuario> GetUsuarios()
        => _repoUser.BuscarTodos();

        public IEnumerable<Cidade> GetCidades()
        => _repoCity.BuscarTodos();

        public IEnumerable<Endereco> GetEnderecos()
        => _repoAddress.BuscarTodos();

        public IEnumerable<LicencaDispositivo> GetDevices()
        => _repoDevice.BuscarTodos();

        public IEnumerable<Licenca> GetLicenses()
        => _repoLicense.BuscarTodos();

        public IEnumerable<LicencaAcesso> GetLicensesAcessControll()
        => _repoAccessControll.BuscarTodos();

        public IEnumerable<Empresa> GetEmpresas()
       => _repoCompany.BuscarTodos();
        */

        /*
        public void teste() {
        _repoLicense._context.Licenses.Include()
        }*/
    }
}