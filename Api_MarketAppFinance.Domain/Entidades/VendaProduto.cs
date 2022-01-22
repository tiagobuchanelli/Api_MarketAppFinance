using Api_MarketAppFinance.Domain.Entities;

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
            Venda venda,
            Produto produto,
            Empresa empresa,
            decimal? valorDesconto = null,
            decimal? valorAscrcescimo = null,
            decimal? pesoLiquido = null,
            decimal? pesoBruto = null,
            string? observacao = null,
            decimal? prDesconto = null
            )
        {
            EmpresaId = empresa.Id;
            CodigoItem = codigoItem;
            VendaId = venda.Id;
            ProdutoId = produto.Id;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
            ValorDesconto = valorDesconto ?? 0;
            ValorAscrcescimo = valorAscrcescimo ?? 0;
            PrDesconto = prDesconto ?? 0;
            PesoLiquido = pesoLiquido ?? 0;
            PesoBruto = pesoBruto ?? 0;
            Observacao = observacao;

            Validar();
        }

        #endregion Construtores

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

        public int EmpresaId { get; private set; }

        public Empresa Empresa { get; private set; }

        public Venda Venda { get; private set; }

        public Produto Produto { get; private set; }

        #endregion Atributos Publicos

        #region Metodos Privados

        private void Validar()
        {
            if (VendaId == default)
                throw new Exception("Obrigatório informar uma venda válida");

            if (ProdutoId == default)
                throw new Exception("Obrigatório informar um produto válido");

            if (CodigoItem <= 0)
                throw new Exception("Obrigatório informar um codigo de item válido");

            if (Quantidade <= 0)
                throw new Exception("Obrigatório informar uma quantidade válida");

            if (ValorUnitario <= 0)
                throw new Exception("Obrigatório informar um valor unitário válido");

            if (ValorTotal <= 0)
                throw new Exception("Obrigatório informar um valor total válido");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }

        #endregion Metodos Privados
    }
}