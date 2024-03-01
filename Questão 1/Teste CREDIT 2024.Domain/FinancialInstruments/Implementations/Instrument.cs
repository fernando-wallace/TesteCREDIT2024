using Teste_CREDIT_2024.Domain.FinancialInstruments.Interfaces;

namespace Teste_CREDIT_2024.Domain.FinancialInstruments.Implementations;

public class Instrument : IFinancialInstrument
{
    public double MarketValue { get; set; }
    public string? Type { get; set; }
}
