using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;

namespace Api_MarketAppFinance.Domain.Services
{
    public class CidadeServico : ServicoBase<Cidade>, ICidadeServico<Cidade>
    {
        private readonly ICidadeRepositorio<Cidade> _cidadeRepositorio;

        public CidadeServico(ICidadeRepositorio<Cidade> userRepository) : base(userRepository)
        {
            this._cidadeRepositorio = userRepository;
        }

        #region Metodos Privados
        private Cidade BuscarCidadePorCodigoIbge(string codigoIbge)
            => _cidadeRepositorio.BuscarCidadePorCodigoIbge(codigoIbge);
        #endregion

        public Cidade AdicionarCidade(Cidade dadosCidade)
        {
            dadosCidade.Validar();

            Adicionar(dadosCidade);
            return BuscarCidadePorCodigoIbge(dadosCidade.CodigoIbge);
        }

        public Cidade AtualizarCidade(Cidade dadosCidade)
        {
            var cidade = BuscarPorCodigo(dadosCidade.Id);
           
            if(cidade is not null)
            {
                cidade.AlterarNomeCidade(dadosCidade.Nome);
                cidade.AlterarCodigoIbge(dadosCidade.CodigoIbge);
                cidade.AlterarCodigoIbgeEstado(dadosCidade.CodigoIbgeEstado);
                cidade.AlterarCep(dadosCidade.Cep);
                cidade.AlterarSiglaEstado(dadosCidade.SiglaEstado);

                Atualizar(cidade);
            }

            return cidade;
        }

        public List<Cidade> BuscarTodos()
        => _cidadeRepositorio.BuscarTodos();

        public Cidade BuscarPorCodigo(int codigo)
        => _cidadeRepositorio.BuscarPorCodigo(codigo);
    }
}