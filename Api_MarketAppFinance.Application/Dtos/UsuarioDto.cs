using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api_MarketAppFinance.Application.Dtos
{
    public class UsuarioDto
    {
        public int Id { get; set; } 

        public string? Nome { get; set; }

        public string? Sobrenome { get; set; }
        
        public string? Email { get; set; }

        public string? Imagem { get; set; }

        public string? Telefone { get; set; }
        
        public string? Documento { get; set; }
    }
}