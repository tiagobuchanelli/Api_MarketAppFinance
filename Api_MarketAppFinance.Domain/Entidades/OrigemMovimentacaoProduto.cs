using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class OrigemMovimentacaoProduto : Base
    {
        #region Construtores

        private OrigemMovimentacaoProduto()
        {
        }

        public OrigemMovimentacaoProduto(string descricao)
        {
            Descricao = descricao;
            Ativo = true;
        }

        #endregion Construtores

        #region Atributos Públicos

        public string Descricao { get; private set; }

        public bool Ativo { get; private set; }

        #endregion Atributos Públicos

        #region Metodos Privados

        #endregion Metodos Privados

        #region Metodos Publicos

        public void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");
        }

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new Exception("Obrigatório informar a descrição.");

            Descricao = descricao;
        }

        #endregion Metodos Publicos
    }
}