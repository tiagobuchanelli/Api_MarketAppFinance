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
        RepositoryAddress _repoAddress = new RepositoryAddress(new SqlContext());
        RepositoryCity _repoCity = new RepositoryCity(new SqlContext());
        RepositoryUser _repoUser = new RepositoryUser(new SqlContext());
        RepositoryCompany _repoCompany = new RepositoryCompany(new SqlContext());
        RepositoryDevice _repoDevice = new RepositoryDevice(new SqlContext());
        RepositoryLicense _repoLicense = new RepositoryLicense(new SqlContext());
        RepositoryLicenseAccessControll _repoAccessControll = new RepositoryLicenseAccessControll(new SqlContext());

        public IEnumerable<User> GetUsuarios()
        => _repoUser.GetAll();

        public IEnumerable<City> GetCidades()
        => _repoCity.GetAll();

        public IEnumerable<Address> GetEnderecos()
        => _repoAddress.GetAll();

        public IEnumerable<Device> GetDevices()
        => _repoDevice.GetAll();

        public IEnumerable<License> GetLicenses()
        => _repoLicense.GetAll();
        
        public IEnumerable<LicensesAccessControll> GetLicensesAcessControll()
        => _repoAccessControll.GetAll();

        public IEnumerable<Company> GetEmpresas()
       => _repoCompany.GetAll();

        /*
        public void teste() {
        _repoLicense._context.Licenses.Include()

        }*/

        
    }

   

}
