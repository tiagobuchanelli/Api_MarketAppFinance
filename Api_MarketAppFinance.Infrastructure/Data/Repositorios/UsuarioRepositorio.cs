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
            try
            {
                var dados = _contexto.Usuarios.FirstOrDefault(x => x.NumeroDocumento == numeroDoc);

                if (dados is null)
                    throw new Exception("Nenhuma cidade encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public Usuario BuscarUsuarioPorEmail(string email)
        {
            try
            {
                var dados = _sqlContext.Usuarios.FirstOrDefault(x => x.Email == email);

                if (dados is null)
                    throw new Exception("Nenhuma cidade encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Usuario BuscarPorCodigo(int codigo)
        {
            try
            {
                var dados = _contexto.Usuarios.FirstOrDefault(x => x.Id == codigo);

                if (dados is null)
                    throw new Exception("Nenhuma cidade encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Usuario> BuscarTodos()
        {
            try
            {
                var dados = _contexto.Usuarios.ToList();

                if (dados is null)
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