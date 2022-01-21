using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class VendaProduto : Base
    {
        #region Construtores
        private VendaProduto()
        {

        }

        public VendaProduto(
            int codigoItem, 
            decimal quantidade, 
            decimal valorUnitario, 
            decimal valorTotal, 
            decimal valorDesconto, 
            decimal valorAscrcescimo,
            Venda venda,
            Produto produto,
            decimal? pesoLiquido = null, 
            decimal? pesoBruto = null, 
            string? observacao = null,             
            decimal? prDesconto = null
            )
        {
            CodigoItem = codigoItem;
            VendaId = venda.Id;
            ProdutoId = produto.Id;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
            ValorDesconto = valorDesconto;
            ValorAscrcescimo = valorAscrcescimo;
            PrDesconto = prDesconto ?? 0;
            PesoLiquido = pesoLiquido ?? 0;
            PesoBruto = pesoBruto ?? 0;
            Observacao = observacao;

            Validar();
        }
        
        #endregion

        #region Atributos Publicos

        public int CodigoItem { get; private set; }     

        public int VendaId { get; private set; }     
        
        public int ProdutoId { get; private set; }        

        public decimal Quantidade { get; private set; }

        public decimal ValorUnitario { get; private set; }

        public decimal ValorTotal { get; private set; }

        public decimal ValorDesconto { get; private set; }

        public decimal ValorAscrcescimo { get; private set; }

        public decimal PrDesconto { get; private set; }

        public decimal PesoLiquido { get; private set; }

        public decimal PesoBruto { get; private set; }

        public string? Observacao { get; private set; }

        public Venda Venda { get; private set; }

        public Produto Produto { get; private set; }


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
    }
}
