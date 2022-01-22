using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class Venda : Base
    {
        #region Construtores
        private Venda()
        {

        }

        public Venda(            
            Empresa empresa,
            Cliente cliente,
            Carteira carteira,
            FormaPagamento formaPagamento,
            decimal numeroDocumento,
            DateTime dataEmissao,            
            string? observacao = null,
            DateTime? dataSaida = null,
            decimal? pesoLiquido = null, 
            decimal? pesoBruto = null, 
            decimal? valorFrete = null, 
            decimal? valorDesconto = null, 
            decimal? valorAcrescimo = null
            )
        {
            Ativo = true;
            EmpresaId = empresa.Id;
            ClienteId = cliente.Id;
            CarteiraId = carteira.Id;
            FormaPagamentoId = formaPagamento.Id;
            NumeroDocumento = numeroDocumento;
            DataEmissao = dataEmissao;
            DataSaida = dataSaida;
            PesoLiquido = pesoLiquido ?? 0;
            PesoBruto = pesoBruto ?? 0;
            ValorFrete = valorFrete ?? 0;
            ValorDesconto = valorDesconto ?? 0;
            ValorAcrescimo = valorAcrescimo ?? 0;
            Observacao = observacao;

            Validar();
        }
        
        #endregion

        #region Atributos Publicos
        public int EmpresaId { get; private set; }
        
        public int ClienteId { get; private set; }

        public int CarteiraId { get; private set; }

        public int FormaPagamentoId { get; private set; }

        public decimal NumeroDocumento { get; private set; }

        public DateTime DataEmissao { get; private set; }

        public DateTime? DataSaida { get; private set; }

        public decimal PesoLiquido { get; private set; }

        public decimal PesoBruto { get; private set; }

        public decimal ValorFrete { get; private set; }

        public decimal ValorDesconto { get; private set; }

        public decimal ValorAcrescimo { get; private set; }

        public string? Observacao { get; private set; }

        public bool Ativo { get; private set; }

        public Empresa Empresa { get; private set; }
        
        public Cliente Cliente { get; private set; }

        public Carteira Carteira { get; private set; }

        public FormaPagamento FormaPagamento { get; private set; }


        #endregion

        #region Metodos Privados
        private void Validar()
        {            
            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");

            if (CarteiraId == default)
                throw new Exception("Obrigatório informar uma carteira válida");

            if (FormaPagamentoId == default)
                throw new Exception("Obrigatório informar uma forma de pagamento válida");

            if (ClienteId == default)
                throw new Exception("Obrigatório informar um cliente válido");

            if (NumeroDocumento <= 0)
                throw new Exception("Obrigatório informar um número de documento válido");

            if (DataEmissao > DateTime.Now)
                throw new Exception("Data de emissão não pode ser posterior a data atual.");
        }
        #endregion

        #region Metodos Publicos
        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;
        #endregion
    }
}
