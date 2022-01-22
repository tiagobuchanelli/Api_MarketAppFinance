using Api_MarketAppFinance.Application.Dtos;

namespace Api_MarketAppFinance.Application.Interfaces
{
    public interface IUsuarioAplicacaoServico
    {
        void Adicionar(UsuarioDto userDto);

        void Atualizar(UsuarioDto userDto);

        void Excluir(UsuarioDto userDto);

        IEnumerable<UsuarioDto> BuscarTodos();

        UsuarioDto BuscarPorCodigo(int id);
    }
}