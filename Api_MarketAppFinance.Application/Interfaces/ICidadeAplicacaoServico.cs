using Api_MarketAppFinance.Application.Dtos;

namespace Api_MarketAppFinance.Application.Interfaces
{
    public interface ICidadeAplicacaoServico
    {
        CidadeDto Adicionar(CidadeDto cityDto);

        CidadeDto Atualizar(CidadeDto cityDto);

        void Excluir(CidadeDto cityDto);

        IEnumerable<CidadeDto> BuscarTodos();

        CidadeDto BuscarPorCodigo(int id);
    }
}