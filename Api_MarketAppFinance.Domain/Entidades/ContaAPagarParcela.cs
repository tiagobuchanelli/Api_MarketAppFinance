using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class ContaAPagarParcela : Base
    {
        #region Construtores
        private ContaAPagarParcela()
        {

        }

        public ContaAPagarParcela(
            int numeroParcela, 
            decimal valorParcela, 
            string observacao, 
            DateTime dataVencimento, 
            DateTime dataPagamento, 
            ContaAPagar contaAPagar,
            FormaPagamento formaPagamento,
            decimal valorAcrescimo, 
            decimal valorDesconto)
        {
            NumeroParcela = numeroParcela;
            ValorParcela = valorParcela;
            Observacao = observacao;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            ContaAPagarId = contaAPagar.Id;
            FormaPagamentoId = formaPagamento.Id;
            ValorAcrescimo = valorAcrescimo;
            ValorDesconto = valorDesconto;
        }

       
        #endregion

        #region Atributos Publicos

        public int ContaAPagarId { get; private set; }

        public int FormaPagamentoId { get; private set; }

        public int NumeroParcela { get; private set; }

        public decimal ValorParcela { get; private set; }

        public decimal ValorAcrescimo { get; private set; }

        public decimal ValorDesconto { get; private set; }

        public string Observacao { get; private set; }

        public DateTime DataVencimento { get; private set; }

        public DateTime DataPagamento { get; private set; }

        public ContaAPagar ContaAPagar { get; private set; }

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
