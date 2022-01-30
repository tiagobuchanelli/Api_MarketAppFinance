using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Application.Dtos
{
    public class CarteiraDto
    {
        public int Id { get; set; }

        public int? EmpresaId { get; set; }

        public EmpresaDto? Empresa { get; set; }

        public string? Descricao { get; set; }

        public string? Abreviacao { get; set; }

        public decimal? ValorMinimoVenda { get; set; }
    }
}
