using Api_MarketAppFinance.Application.Dtos;

namespace Api_MarketAppFinance.Application.Interfaces
{
    public interface IUsuarioAplicacaoServico
    {
        void Add(UsuarioDto userDto);

        void Update(UsuarioDto userDto);

        void Remove(UsuarioDto userDto);

        IEnumerable<UsuarioDto> GetAll();

        UsuarioDto GetById(int id);
    }
}