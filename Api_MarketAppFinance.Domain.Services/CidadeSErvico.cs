using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;

namespace Api_MarketAppFinance.Domain.Services
{
    public class CidadeServico : ServicoBase<Cidade>, ICidadeSErvico<Cidade>
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
            var cidade = new Cidade(
                nomeCidade: dadosCidade.Nome,
                codigoIbge: dadosCidade.CodigoIbge,
                codigoIbgeEstado: dadosCidade.CodigoIbgeEstado,
                sigla: dadosCidade.SiglaEstado,
                cep: dadosCidade.Cep
                );

            Adicionar(cidade);
            return BuscarCidadePorCodigoIbge(dadosCidade.CodigoIbge);
        }

        public Cidade AtualizarCidade(Cidade dadosCidade)
        {
            var cidade = BuscarPorCodigo(dadosCidade.Id);
            cidade.AlterarNomeCidade(dadosCidade.Nome);            
            cidade.AlterarCodigoIbge(dadosCidade.CodigoIbge);
            cidade.AlterarCodigoIbgeEstado(dadosCidade.CodigoIbgeEstado);
            cidade.AlterarCep(dadosCidade.Cep);
            cidade.AlterarSiglaEstado(dadosCidade.SiglaEstado);

            Atualizar(cidade);

            return cidade;
        }
    }
}