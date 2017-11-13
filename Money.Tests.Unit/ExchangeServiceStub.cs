using System;
namespace MoneyExercise.Tests.Unit
{
    public class ExchangeServiceStub : CurrencyConverting
    {
        public Decimal convert(Decimal amount, Currency inputCurrency, Currency targetCurrency)
        {
            return amount * 2.0m;
        }
    }
}
