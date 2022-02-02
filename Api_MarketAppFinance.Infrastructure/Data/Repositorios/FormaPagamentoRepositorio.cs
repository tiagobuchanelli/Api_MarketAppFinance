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
            return _contexto.FormasPagamento.FirstOrDefault(x => x.Id == codigo && x.EmpresaId == idEmpresa);
        }

        public List<FormaPagamento> BuscarTodos(int idEmpresa)
        => _contexto.FormasPagamento.Where(x => x.EmpresaId == idEmpresa).ToList();

        public List<FormaPagamento> BuscarFormasPagamento(int idEmpresa)
        {
            return _contexto.FormasPagamento.Include(x => x.Empresa).Include(x => x.Carteira).Where(x => x.EmpresaId == idEmpresa).ToList();
        }
    }
}