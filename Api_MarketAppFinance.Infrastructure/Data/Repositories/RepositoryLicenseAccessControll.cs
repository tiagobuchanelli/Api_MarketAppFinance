using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class RepositoryLicenseAccessControll : RepositoryBase<LicensesAccessControll>, IRepositoryLicenseAccessControll
    {
        private readonly SqlContext _sqlContext;

        public RepositoryLicenseAccessControll(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}