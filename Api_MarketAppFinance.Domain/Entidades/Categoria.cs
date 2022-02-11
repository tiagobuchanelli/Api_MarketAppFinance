using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class Categoria : Base
    {
        #region Construtores

        private Categoria()
        {
        }

        public Categoria(string descricao, Empresa empresa)
        {
            Descricao = descricao;
            EmpresaId = empresa.Id;
            Ativo = true;
        }

        #endregion Construtores

        #region Atributos Públicos

        public string Descricao { get; private set; }

        public int EmpresaId { get; private set; }

        public bool Ativo { get; private set; }

        public Empresa Empresa { get; private set; }

        public IList<SubCategoria> SubCategorias { get; private set; }

        #endregion Atributos Públicos

        #region Metodos Privados


        #endregion Metodos Privados

        #region Metodos Publicos

        public void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
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