using Teste_CREDIT_2024.Domain.Categories.Interfaces;

namespace Teste_CREDIT_2024.Domain.Categories.Implementations;

public class LowValueCategory : IMarketValueCategory
{
    public string Name => "Low Value";
    public bool IsInCategory(double marketValue) => marketValue < 1_000_000;
}
