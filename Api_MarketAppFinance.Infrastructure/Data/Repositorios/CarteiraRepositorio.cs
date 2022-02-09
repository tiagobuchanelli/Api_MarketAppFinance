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
            try
            {
                var dados = _contexto.Carteiras.FirstOrDefault(x => x.Id == codigo && x.EmpresaId == idEmpresa);

                if (dados is null)
                    throw new Exception("Nenhuma carteira encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }        

        public List<Carteira> BuscarCarteiras(int idEmpresa)
        {   
            try
            {
                var dados = _contexto.Carteiras.Include(x => x.Empresa).Where(x => x.EmpresaId == idEmpresa).ToList();

                if (dados is null || dados.Count == 0)
                    throw new Exception("Nenhuma carteira encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}