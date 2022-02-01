using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Application.Dtos
{
    public class FormaPagamentoDto
    {
        public int Id { get; set; }

        public string? Descricao { get; set; }

        public int? EmpresaId { get; set; }

        public EmpresaDto? Empresa { get; set; }

        public int? TipoPagamento { get; set; }

        public CarteiraDto? Carteira { get; set; }

        public string? Abreviacao { get; set; }        

        public decimal? ValorAcrescimo { get; set; }

        public decimal? ValorDesconto { get; set; }

        public decimal? PercentualDesconto { get; set; }

        public decimal? PercentualAcrescimo { get; set; }

        public decimal? DiasIntervalo { get; set; }

        public decimal? DiasLimiteIntervalo { get; set; }

        public decimal? NumeroIntervalos { get; set; }
        
        public int? DiaPadraoVencimento { get; set; }

        public bool? GerarFinanceiro { get; set; }
    }
}
