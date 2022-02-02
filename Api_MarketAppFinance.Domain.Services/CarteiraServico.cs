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

        public void Atualizar(FormaPagamento obj)
        {
            throw new NotImplementedException();
        }

        public Carteira AtualizarCarteira(Carteira dadosCarteira)
        {
            var carteira = BuscarPorCodigo(dadosCarteira.EmpresaId, dadosCarteira.Id);

            if(carteira is not null)
            {
                carteira.AlterarDescricao(dadosCarteira.Descricao);
                carteira.AlterarAbreviacao(dadosCarteira.Abreviacao);

                Atualizar(carteira);
            }            

            return carteira;
        }

        public List<Carteira> BuscarCarteiras(int codigoEmpresa)
        => _carteiraRepositorio.BuscarCarteiras(codigoEmpresa);

        public Carteira BuscarPorCodigo(int codigoEmpresa, int codigo)
        => _carteiraRepositorio.BuscarPorCodigo(codigoEmpresa, codigo);

        public void Excluir(FormaPagamento obj)
        {
            throw new NotImplementedException();
        }
    }
}