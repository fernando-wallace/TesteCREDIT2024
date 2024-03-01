namespace Teste_CREDIT_2024.Domain.FinancialInstruments.Interfaces;

public interface IFinancialInstrument
{
    double MarketValue { get; }
    string? Type { get; }
}
