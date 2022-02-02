using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class EmpresaRepositorio : BaseRepositorio<Empresa>, IEmpresaRepositorio<Empresa>
    {
        private readonly ContextoBase _sqlContext;

        public EmpresaRepositorio(ContextoBase sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;            
        }

        public Empresa BuscarInformacoesEmpresa(string documento)
        => _sqlContext.Empresas.Include(x => x.Usuario).Include(x => x.Licencas).FirstOrDefault(x => x.NumeroDocumento == documento);

        public Empresa BuscarPorCodigo(int codigo)
        {
            return _contexto.Empresas.FirstOrDefault(x => x.Id == codigo);
        }

        public List<Empresa> BuscarTodos()
        {
            return _contexto.Empresas.ToList();
        }


    }
}