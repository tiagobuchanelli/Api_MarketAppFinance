using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio<Usuario>
    {
        private readonly ContextoBase _sqlContext;

        public UsuarioRepositorio(ContextoBase sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public Usuario BuscarUsuarioPorDocumento(string numeroDoc)
        {
            return _contexto.Set<Usuario>().FirstOrDefault(x => x.NumeroDocumento == numeroDoc);
        }

       
    }
}