using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class ImagemProduto : Base
    {
        public ImagemProduto(string url, Produto produto, Empresa empresa)
        {
            Url = url;
            ProdutoId = produto.Id;
            Ativo = true;
            EmpresaId = empresa.Id;
        }

        #region Construtores

        private ImagemProduto()
        {
        }

        #endregion Construtores

        #region Atributos Publicos

        public string Url { get; private set; }

        public int ProdutoId { get; set; }

        public bool Ativo { get; private set; }

        public int EmpresaId { get; private set; }

        public Empresa Empresa { get; private set; }

        public Produto Produto { get; set; }

        #endregion Atributos Publicos

        #region Metodos Privados

        #endregion Metodos Privados

        #region Petodos Publicos

        public void Validate()
        {
            if (string.IsNullOrEmpty(Url))
                throw new Exception("Obrigatório informar a url.");

            if (ProdutoId == default)
                throw new Exception("Obrigatório informar um produto válido");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new Exception("Obrigatório informar a url.");

            Url = url;
        }

        #endregion Petodos Publicos
    }
}