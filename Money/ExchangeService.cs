using System;
namespace MoneyExercise
{
    public interface CurrencyConverting
    {
        Decimal convert(Decimal amount, Currency inputCurrency, Currency targetCurrency);
    }

    public class ExchangeService : CurrencyConverting
    {
        public Decimal convert(Decimal amount, Currency inputCurrency, Currency targetCurrency)
        {
            return amount * (Decimal) new Random().NextDouble() + 1;
        }
    }
}
