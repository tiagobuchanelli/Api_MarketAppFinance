using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

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
       
    }
}