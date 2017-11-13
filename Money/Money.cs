using System;

namespace MoneyExercise
{
    public class Money
    {
        private Decimal amount;
        private Currency currency;
        private CurrencyConverting exchangeService = new ExchangeService();

        public void SetExchangeService(CurrencyConverting newExchangeService)
        {
            exchangeService = newExchangeService;
        }

        public Decimal Amount
        {
            get { return amount; }
        }

        public Currency Currency
        {
            get { return currency; }
        }

        public Money(Decimal amount, Currency currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money add(Money other)
        {
            if (currency != other.currency)
            {
                amount = exchangeService.convert(amount, currency, other.Currency);
            }
            return new Money(amount + other.amount, other.currency);
        }

        public override bool Equals(Object other)
        {
            if (other == null || other.GetType() != GetType())
            {
                return false;
            }

            Money otherMoney = (Money) other;
            return otherMoney.Amount == amount && otherMoney.Currency == currency;
        }

        public override int GetHashCode()
        {
            return amount.GetHashCode() ^ currency.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("[Money: Amount={0}, Currency={1}]", Amount, Currency);
        }
    }

    public enum Currency
    {
        USD,
        CAD
    }
}
