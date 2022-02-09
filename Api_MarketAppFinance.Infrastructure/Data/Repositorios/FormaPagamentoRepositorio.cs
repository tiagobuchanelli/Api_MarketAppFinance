using Api_MarketAppFinance.Data;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api_MarketAppFinance.Infrastructure.Data.Repositories
{
    public class FormaPagamentoRepositorio : BaseRepositorio<FormaPagamento>, IFormaPagamentoRepositorio<FormaPagamento>
    {
        private readonly ContextoBase _contexto;

        public FormaPagamentoRepositorio(ContextoBase sqlContext) : base(sqlContext)
        {
            _contexto = sqlContext;
        }

        public FormaPagamento BuscarPorCodigo(int idEmpresa, int codigo)
        {
            try
            {
                var dados = _contexto.FormasPagamento.FirstOrDefault(x => x.Id == codigo && x.EmpresaId == idEmpresa);

                if (dados is null)
                    throw new Exception("Nenhuma forma de pagamento encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<FormaPagamento> BuscarTodos(int idEmpresa)
        {
            try
            {
                var dados = _contexto.FormasPagamento.Where(x => x.EmpresaId == idEmpresa).ToList();

                if (dados is null || dados.Count == 0)
                    throw new Exception("Nenhuma forma de pagamento encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<FormaPagamento> BuscarFormasPagamento(int idEmpresa)
        {
            try
            {
                var dados = _contexto.FormasPagamento.Include(x => x.Empresa).Include(x => x.Carteira).Where(x => x.EmpresaId == idEmpresa).ToList();

                if (dados is null || dados.Count == 0)
                    throw new Exception("Nenhuma forma de pagamento encontrada");

                return dados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}