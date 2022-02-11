using Api_MarketAppFinance.Application.Dtos;

namespace Api_MarketAppFinance.Application.Interfaces
{
    public interface ICarteiraAplicacaoServico
    {
        CarteiraDto Adicionar(CarteiraDto carteira);

        CarteiraDto Atualizar(CarteiraDto carteira);

        //void Excluir(CarteiraDto carteira);

        IEnumerable<CarteiraDto> BuscarCarteiras(int codigoEmpresa);

        CarteiraDto BuscarPorCodigo(int idEmpresa, int id);

    }
}