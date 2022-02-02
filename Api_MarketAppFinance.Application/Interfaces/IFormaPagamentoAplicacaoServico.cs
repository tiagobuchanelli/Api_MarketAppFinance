using Api_MarketAppFinance.Application.Dtos;

namespace Api_MarketAppFinance.Application.Interfaces
{
    public interface IFormaPagamentoAplicacaoServico
    {
        FormaPagamentoDto Adicionar(FormaPagamentoDto carteira);

        FormaPagamentoDto Atualizar(FormaPagamentoDto carteira);

        void Excluir(FormaPagamentoDto carteira);

        IEnumerable<FormaPagamentoDto> BuscarFormasPagamento(int codigoEmpresa);

        FormaPagamentoDto BuscarPorCodigo(int idEmpresa, int id);

    }
}