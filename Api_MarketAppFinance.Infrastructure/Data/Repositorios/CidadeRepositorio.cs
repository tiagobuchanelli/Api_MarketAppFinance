using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class CidadeRepositorio : BaseRepositorio<Cidade>, ICidadeRepositorio
    {
        private readonly ContextoBase _sqlContext;

        public CidadeRepositorio(ContextoBase sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}