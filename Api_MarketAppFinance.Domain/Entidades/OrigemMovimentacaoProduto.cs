using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Validar();
        }


        #endregion

        #region Atributos Públicos
        public string Descricao { get; private set; }

        public bool Ativo { get; private set; }
        #endregion

        #region Metodos Privados
        private void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");
            
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
        #endregion

    }
}
