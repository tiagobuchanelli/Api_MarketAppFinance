using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Repositories
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        public readonly ContextoBase _contexto;

        public BaseRepositorio(ContextoBase sqlContexto) => this._contexto = sqlContexto;

        public void Adicionar(TEntity entidade)
        {
            try
            {
                _contexto.Add(entidade);
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Atualizar(TEntity entidade)
        {
            try
            {
                _contexto.Update(entidade);
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Excluir(TEntity entidade)
        {
            try
            {
                _contexto.Remove(entidade);
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            try
            {
                return _contexto.Set<TEntity>().ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TEntity BuscarPorCodigo(int id)
        {
            try
            {
                return _contexto.Set<TEntity>().Find(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}