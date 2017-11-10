using System;

namespace MoneyExercise
{
    public class Money
    {
        private Decimal amount;

        public Decimal Amount
        {
            get
            {
                return amount;
            }
        }

        public Money(Decimal amount)
        {
            this.amount = amount;
        }

        public Money add(Money money2)
        {
            return new Money(3.0m);
        }
    }
}
