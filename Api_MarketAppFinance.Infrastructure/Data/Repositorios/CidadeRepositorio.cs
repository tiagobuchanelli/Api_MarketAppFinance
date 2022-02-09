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
            try
            {
                var dados = _contexto.Cidades.FirstOrDefault(x => x.CodigoIbge == codigoIbge);

                if (dados is null)
                    throw new Exception("Nenhuma cidade encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Cidade BuscarPorCodigo(int codigo)
        {
            try
            {
                var dados = _contexto.Cidades.FirstOrDefault(x => x.Id == codigo);

                if (dados is null)
                    throw new Exception("Nenhuma cidade encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Cidade> BuscarTodos()
        {
            try
            {
                var dados = _contexto.Cidades.ToList();

                if (dados is null || dados.Count == 0)
                    throw new Exception("Nenhuma cidade encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}