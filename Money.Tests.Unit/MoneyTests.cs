using NUnit.Framework;
using System;
namespace MoneyExercise.Tests.Unit
{
    public class MoneyTests
    {
        [Test]
        public void TestCase()
        {
            Money money2 = new Money(1.0m);
            Money money1 = new Money(2.0m);

            Money sum = money1.add(money2);

            Assert.That(sum.Amount, Is.EqualTo(3.0m));
        }
    }
}
