namespace Api_MarketAppFinance.Application.Dtos
{
    public class CidadeDto
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Cep { get; set; }

        public string? CodigoIbge { get; set; }

        public string? CodigoIbgeEstado { get; set; }

        public string? SiglaEstado { get; set; }
    }
}