using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;

namespace Api_MarketAppFinance.Infrastructure.Repositories
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        public readonly ContextoBase _context;

        public BaseRepositorio(ContextoBase sqlContext) => this._context = sqlContext;

        public void Add(TEntity entidade)
        {
            try
            {
                _context.Add(entidade);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(TEntity entidade)
        {
            try
            {
                _context.Update(entidade);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Remove(TEntity entidade)
        {
            try
            {
                _context.Remove(entidade);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _context.Set<TEntity>().ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                return _context.Set<TEntity>().Find(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}