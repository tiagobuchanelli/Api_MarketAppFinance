using Api_MarketAppFinance.Application.Dtos;

namespace Api_MarketAppFinance.Application.Interfaces
{
    public interface ICidadeAplicacaoServico
    {
        void Add(CidadeDto cityDto);

        void Update(CidadeDto cityDto);

        void Remove(CidadeDto cityDto);

        IEnumerable<CidadeDto> GetAll();

        CidadeDto GetById(int id);
    }
}