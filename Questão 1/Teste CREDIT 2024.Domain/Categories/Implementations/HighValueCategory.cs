using Teste_CREDIT_2024.Domain.Categories.Interfaces;

namespace Teste_CREDIT_2024.Domain.Categories.Implementations;

public class HighValueCategory : IMarketValueCategory
{
    public string Name => "High Value";
    public bool IsInCategory(double marketValue) => marketValue > 5_000_000;
}
