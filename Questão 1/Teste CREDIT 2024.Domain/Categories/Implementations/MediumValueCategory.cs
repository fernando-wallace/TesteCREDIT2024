using Teste_CREDIT_2024.Domain.Categories.Interfaces;

namespace Teste_CREDIT_2024.Domain.Categories.Implementations;

public class MediumValueCategory : IMarketValueCategory
{
    public string Name => "Medium Value";
    public bool IsInCategory(double marketValue) => marketValue >= 1_000_000 && marketValue <= 5_000_000;
}
