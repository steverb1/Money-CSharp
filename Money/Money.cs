using System;

namespace MoneyExercise
{
    public class Money
    {
        private Decimal amount;
        private Currency currency;

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
            return new Money(amount + other.amount, currency);
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
    }

    public enum Currency
    {
        USD
    }
}
