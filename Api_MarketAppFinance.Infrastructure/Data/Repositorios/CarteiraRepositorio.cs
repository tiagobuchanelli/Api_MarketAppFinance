using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class CarteiraRepositorio : BaseRepositorio<Carteira>, ICarteiraRepositorio<Carteira>
    {
        private readonly ContextoBase _contexto;

        public CarteiraRepositorio(ContextoBase sqlContext) : base(sqlContext)
        {
            _contexto = sqlContext;
        }

        public Carteira BuscarPorCodigo(int idEmpresa, int codigo)
        {
            return _contexto.Carteiras.FirstOrDefault(x => x.Id == codigo && x.EmpresaId == idEmpresa);
        }

        public List<Carteira> BuscarTodos(int idEmpresa)
        => _contexto.Carteiras.Where(x => x.EmpresaId == idEmpresa).ToList();

        public List<Carteira> BuscarCarteiras(int idEmpresa)
        {
            return _contexto.Carteiras.Include(x => x.Empresa).Where(x => x.EmpresaId == idEmpresa).ToList();
        }
    }
}