using System.Text.Json;
using Teste_CREDIT_2024.Domain.Categories.Implementations;
using Teste_CREDIT_2024.Domain.Categories.Interfaces;
using Teste_CREDIT_2024.Domain.FinancialInstruments.Implementations;
using Teste_CREDIT_2024.Domain.FinancialInstruments.Interfaces;
using Teste_CREDIT_2024.Infrastructure.Services;

namespace Teste_CREDIT_2024
{
    public class Worker : BackgroundService
    {
        private InstrumentCategorizerService categorizer;

        public Worker()
        {
            List<IMarketValueCategory> categories = new()
            {
                new LowValueCategory(),
                new MediumValueCategory(),
                new HighValueCategory()
            };

            categorizer = new(categories);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            List<IFinancialInstrument> instruments = new()
            {
                new Instrument() { MarketValue = 800000, Type = "Stock" },
                new Instrument { MarketValue = 1500000, Type = "Bond" },
                new Instrument { MarketValue = 6000000, Type = "Derivative" },
                new Instrument { MarketValue = 300000, Type = "Stock" }
            };

            List<string> resultsList = categorizer.CategorizeList(instruments);
            Console.WriteLine(JsonSerializer.Serialize(resultsList));

            return Task.CompletedTask;
        }
    }
}