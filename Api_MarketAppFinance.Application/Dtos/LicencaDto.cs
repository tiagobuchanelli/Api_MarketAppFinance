using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Application.Dtos
{
    public class LicencaDto
    {
        public int Id { get; set; }

        public string? Descricao { get; set; }

        public string? Tipo { get; set; }

        public int? NumeroAcecsso { get; set; }

        public DateTime? DataValidade { get; set; }

        public EmpresaDto? Empresa { get; set; }

    }
}
