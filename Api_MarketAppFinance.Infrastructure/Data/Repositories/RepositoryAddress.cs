using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class RepositoryAddress : RepositoryBase<Address>, IRepositoryAddress
    {
        private readonly SqlContext _sqlContext;

        public RepositoryAddress(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
            
        }
                
                
    }
}