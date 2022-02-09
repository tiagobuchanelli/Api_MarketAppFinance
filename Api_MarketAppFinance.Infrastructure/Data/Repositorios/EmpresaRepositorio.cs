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
        {
            try
            {
                var dados = _sqlContext.Empresas.Include(x => x.Usuario).Include(x => x.Licencas).FirstOrDefault(x => x.NumeroDocumento == documento);

                if (dados is null)
                    throw new Exception("Nenhuma empresa encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public Empresa BuscarPorCodigo(int codigo)
        {
            try
            {
                var dados = _contexto.Empresas.FirstOrDefault(x => x.Id == codigo);

                if (dados is null)
                    throw new Exception("Nenhuma empresa encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Empresa> BuscarTodos()
        {
            try
            {
                var dados = _contexto.Empresas.ToList();

                if (dados is null)
                    throw new Exception("Nenhuma empresa encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}