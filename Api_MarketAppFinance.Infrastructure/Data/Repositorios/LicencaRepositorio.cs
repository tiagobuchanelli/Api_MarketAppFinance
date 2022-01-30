using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class LicencaRepositorio : BaseRepositorio<Licenca>, ILicencaRepositorio<Licenca>
    {
        private readonly ContextoBase _sqlContext;

        public LicencaRepositorio(ContextoBase sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public List<Licenca> BuscarLicencaPorEmpresa(int codigoEmpresa)
        {
           return _sqlContext.Licensas.Where(x => x.EmpresaId == codigoEmpresa).ToList();
        }
    }
}