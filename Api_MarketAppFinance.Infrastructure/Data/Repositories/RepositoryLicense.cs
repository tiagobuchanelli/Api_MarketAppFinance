using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class RepositoryLicense : RepositoryBase<License>, IRepositoryLicense
    {
        private readonly SqlContext _sqlContext;

        public RepositoryLicense(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}