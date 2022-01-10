namespace Api_MarketAppFinance.Application.Dtos
{
    public class CidadeDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? ZipCode { get; set; }

        public string CodeIgbe { get; set; }

        public string StateCodeIgbe { get; set; }

        public string? StateSymbol { get; set; }

    }
}