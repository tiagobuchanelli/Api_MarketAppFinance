using Api_MarketAppFinance.Application.Dtos;

namespace Api_MarketAppFinance.Application.Interfaces
{
    public interface IUsuarioAplicacaoServico
    {
        UsuarioDto? Autenticar(UsuarioDto userDto);        

        UsuarioDto Adicionar(UsuarioDto userDto);

        UsuarioDto Atualizar(UsuarioDto userDto);

        void Excluir(UsuarioDto userDto);

        IEnumerable<UsuarioDto> BuscarTodos();

        UsuarioDto BuscarPorCodigo(int id);
    }
}