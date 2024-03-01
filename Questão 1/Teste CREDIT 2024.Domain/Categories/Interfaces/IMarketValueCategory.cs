namespace Teste_CREDIT_2024.Domain.Categories.Interfaces;

public interface IMarketValueCategory
{
    public string Name { get; }
    public bool IsInCategory(double marketValue);
}
