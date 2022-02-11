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
            dadosCarteira.Validar();

            Adicionar(dadosCarteira);
            return BuscarCarteiras(dadosCarteira.Empresa.Id).Last();
            
        }
        

        public Carteira AtualizarCarteira(Carteira dadosCarteira)
        {
            var carteira = BuscarPorCodigo(dadosCarteira.EmpresaId, dadosCarteira.Id);            
            carteira.AlterarDescricao(dadosCarteira.Descricao);
            carteira.AlterarAbreviacao(dadosCarteira.Abreviacao);

            Atualizar(carteira);
            return carteira;


        }

        public List<Carteira> BuscarCarteiras(int codigoEmpresa)
        {
            var dados = _carteiraRepositorio.BuscarCarteiras(codigoEmpresa);

            if (dados is null || dados.Count == 0)
                throw new Exception("Nenhuma carteira encontrada");

            return dados;           
        }

        public Carteira BuscarPorCodigo(int codigoEmpresa, int codigo)
        {
            var carteira = _carteiraRepositorio.BuscarPorCodigo(codigoEmpresa, codigo);

            if (carteira is null)
                throw new Exception("Nenhuma carteira encontrada");

             return carteira;
        }
        
    }
}