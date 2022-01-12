using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class SubCategoria : Base
    {
        #region Construtores
        private SubCategoria()
        {
        }

        public SubCategoria(string descricao, Categoria categoria, Empresa empresa)
        {
            Descricao = descricao;
            CategoriaId = categoria.Id;
            Ativo = true;
            EmpresaId = empresa.Id;

            Validar();
        }

        
        #endregion

        #region Atributos Públicos
        public string Descricao { get; private set; }

        public bool Ativo { get; private set; }

        public int CategoriaId { get; private set; }

        public int EmpresaId { get; private set; }

        public Empresa Empresa { get; private set; }

        public Categoria Categoria { get; private set; }
        #endregion

        #region Metodos Privados
        private void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");

            if (CategoriaId == default)
                throw new Exception("Obrigatório informar uma categoria válida");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }
        #endregion

        #region Metodos Publicos
        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarDescricao(string descricao) 
        {
            if (string.IsNullOrEmpty(descricao))
                throw new Exception("Obrigatório informar a descrição.");

            Descricao = descricao;
        }

        public void AlterarCategoria(Categoria categoria)
        {
            if (categoria is null)
                throw new Exception("Informe uma categoria válida");

            CategoriaId = categoria.Id;
        }
        #endregion

    }
}
