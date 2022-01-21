using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class VendaParcela : Base
    {
        #region Construtores
        private VendaParcela()
        {

        }

        public VendaParcela(
            int numeroParcela, 
            DateTime dataVencimento, 
            decimal valorParcela, 
            Venda venda, 
            VendaFormaPagamento vendaFormaPagamento
            )
        {
            VendaId = venda.Id;
            VendaFormaPagamentoId = vendaFormaPagamento.Id;
            NumeroParcela = numeroParcela;
            DataVencimento = dataVencimento;
            ValorParcela = valorParcela;

            Validar();
        }


        #endregion

        #region Atributos Publicos
        public int VendaId { get; private set; }

        public int VendaFormaPagamentoId { get; private set; }

        public int NumeroParcela { get; private set; }

        public DateTime DataVencimento { get; private set; }

        public decimal ValorParcela { get; private set; }

        public Venda Venda { get; private set; }

        public VendaFormaPagamento VendaFormaPagamento { get; private set; }


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
