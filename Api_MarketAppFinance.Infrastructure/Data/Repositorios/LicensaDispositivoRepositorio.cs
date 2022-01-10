using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class LicensaDispositivoRepositorio : BaseRepositorio<LicencaAcesso>, ILicensaDispositivoRepositorio
    {
        private readonly ContextoBase _sqlContext;

        public LicensaDispositivoRepositorio(ContextoBase sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}