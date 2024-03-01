using Teste_CREDIT_2024.Domain.Categories.Interfaces;
using Teste_CREDIT_2024.Domain.FinancialInstruments.Interfaces;

namespace Teste_CREDIT_2024.Infrastructure.Services;

public class InstrumentCategorizerService
{
    private readonly List<IMarketValueCategory> categories;

    public InstrumentCategorizerService(List<IMarketValueCategory> categories)
    {
        this.categories = categories;
    }

    public string Categorize(IFinancialInstrument instrument)
    {
        try
        {
            IMarketValueCategory? category = categories.FirstOrDefault(c => c.IsInCategory(instrument.MarketValue));
            return category?.Name ?? "Uncategorized";
        }
        catch (Exception e)
        {
            throw new Exception($"Erro ao categorizar instrumento. Exceção: {e}.");
        }
    }

    public List<string> CategorizeList(List<IFinancialInstrument> instrumentsList)
    {
        try
        {
            List<string> resultsList = new();
            resultsList.AddRange(instrumentsList.Select(tb => Categorize(tb)));
            return resultsList;
        }
        catch (Exception e)
        {
            throw new Exception($"Erro ao categorizar lista de instrumentos. Exceção: {e}.");
        }
    }
}