using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class Dispositvo : BaseRepositorio<LicencaDispositivo>, IDispositvo
    {
        private readonly ContextoBase _sqlContext;

        public Dispositvo(ContextoBase sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}