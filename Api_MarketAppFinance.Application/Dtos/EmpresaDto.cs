using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Application.Dtos
{
    public class EmpresaDto
    {
        public int Id { get; set; }

        public string? NomeFantasia { get; set; }

        public string? RazaoSocial { get; set; }

        public string? Documento { get; set; }

        public string? Telefone { get; set; }

        public int? UsuarioId { get; set; }

        public string? Imagem { get; set; }

        public UsuarioDto? Usuario { get; set; }

        public List<LicencaDto>? Licencas { get; set; }
    }
}
