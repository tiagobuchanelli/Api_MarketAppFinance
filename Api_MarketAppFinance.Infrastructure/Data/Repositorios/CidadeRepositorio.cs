using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class CidadeRepositorio : BaseRepositorio<Cidade>, ICidadeRepositorio<Cidade>
    {
        private readonly ContextoBase _contexto;

        public CidadeRepositorio(ContextoBase sqlContext) : base(sqlContext)
        {
            _contexto = sqlContext;
        }

        public Cidade BuscarCidadePorCodigoIbge(string codigoIbge)
        {
            return _contexto.Set<Cidade>().FirstOrDefault(x => x.CodigoIbge == codigoIbge);
        }
    }
}