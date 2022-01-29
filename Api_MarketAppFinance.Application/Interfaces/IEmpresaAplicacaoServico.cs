using Api_MarketAppFinance.Application.Dtos;

namespace Api_MarketAppFinance.Application.Interfaces
{
    public interface IEmpresaAplicacaoServico
    {
        EmpresaDto Adicionar(EmpresaDto userDto);

        EmpresaDto Atualizar(EmpresaDto userDto);

        void Excluir(EmpresaDto userDto);

        IEnumerable<EmpresaDto> BuscarTodos();

        EmpresaDto BuscarPorCodigo(int id);

        EmpresaDto BuscarInformacoesEmpresa(string documento);
    }
}