using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Api_MarketAppFinance.Application.Dtos
{
    
    public class UsuarioDto
    {
        public int Id { get; set; } 

        public string Nome { get; set; }

        public string Sobrenome { get; set; }
        
        public string Email { get; set; }

        public string? Imagem { get; set; }

        public string? Telefone { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Documento { get; set; }
    }
}