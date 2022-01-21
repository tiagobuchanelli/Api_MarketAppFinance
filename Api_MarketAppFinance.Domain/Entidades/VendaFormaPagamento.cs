using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class VendaFormaPagamento : Base
    {
       
        #region Construtores
        private VendaFormaPagamento()
        {

        }

        public VendaFormaPagamento(
            decimal valor, 
            Venda venda, 
            Carteira carteira, 
            FormaPagamento formaPagamento)
        {
            VendaId = venda.Id;
            CarteiraId = carteira.Id;
            FormaPagamentoId = formaPagamento.Id;
            Valor = valor;

            Validar();
        }



        #endregion

        #region Atributos Publicos
        public int VendaId { get; private set; }

        public int CarteiraId { get; private set; }

        public int FormaPagamentoId { get; private set; }

        public decimal Valor { get; private set; }

        public Venda Venda { get; private set; }

        public Carteira Carteira { get; private set; }

        public FormaPagamento FormaPagamento { get; private set; }


        #endregion

        #region Metodos Privados
        private void Validar()
        {
            /*if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");

            if (CategoriaId == default)
                throw new Exception("Obrigatório informar uma categoria válida");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
            */
        }
        #endregion

        #region Metodos Publicos
        
        #endregion
    }
}
