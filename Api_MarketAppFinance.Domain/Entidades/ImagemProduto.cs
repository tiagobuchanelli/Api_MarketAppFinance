using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Validate();

        }
       
        #region Construtores
        private ImagemProduto()
        {
        }

        #endregion

        #region Atributos Publicos
        public string Url { get; private set; }

        public int ProdutoId { get; set; }

        public bool Ativo { get; private set; }

        public int EmpresaId { get; private set; }

        public Empresa Empresa { get; private set; }

        public Produto Produto { get; set; }

        #endregion

        #region Metodos Privados
        private void Validate()
        {
            if (string.IsNullOrEmpty(Url))
                throw new Exception("Obrigatório informar a url.");

            if (ProdutoId == default)
                throw new Exception("Obrigatório informar um produto válido");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");

        }
        #endregion

        #region Petodos Publicos
        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarUrl(string url) 
        { 
            if(string.IsNullOrEmpty(url))
                throw new Exception("Obrigatório informar a url.");

            Url = url;
        }
        #endregion
    }
}
