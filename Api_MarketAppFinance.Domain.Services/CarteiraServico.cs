using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;

namespace Api_MarketAppFinance.Domain.Services
{
    public class CarteiraServico : ServicoBase<Carteira>, ICarteiraServico<Carteira>
    {
        private readonly ICarteiraRepositorio<Carteira> _carteiraRepositorio;

        public CarteiraServico(ICarteiraRepositorio<Carteira> carteiraRepositorio) : base(carteiraRepositorio)
        {
            this._carteiraRepositorio = carteiraRepositorio;
        }

        #region Metodos Privados
        
        #endregion

        public Carteira AdicionarCarteira(Carteira dadosCarteira)
        {
            
            var carteira = new Carteira(
                desc: dadosCarteira.Descricao,
                empresa: dadosCarteira.Empresa,
                abreviacao: dadosCarteira.Abreviacao,
                valorMinimoVenda: dadosCarteira.ValorMinimoVenda
                );

            Adicionar(carteira);
            return BuscarCarteiras(dadosCarteira.Empresa.Id).Last();
            
        }

        public Carteira AtualizarCarteira(Carteira dadosCarteira)
        {
            var carteira = BuscarPorCodigo(dadosCarteira.Id);
            carteira.AlterarDescricao(dadosCarteira.Descricao);            
            carteira.AlterarAbreviacao(dadosCarteira.Abreviacao);

            Atualizar(carteira);

            return carteira;
        }

        public List<Carteira> BuscarCarteiras(int codigoEmpresa)
        => _carteiraRepositorio.BuscarCarteiras(codigoEmpresa);
    }
}