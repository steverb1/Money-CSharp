using NUnit.Framework;
using System;
using Moq;

namespace MoneyExercise.Tests.Unit
{
    public class MoneyTests
    {
        [Test]
        public void OnePlusTwo_EqualsThree()
        {
            Money money1 = new Money(1.0m, Currency.USD);
            Money money2 = new Money(2.0m, Currency.USD);

            Money sum = money1.add(money2);

            Money expectedResult = new Money(3.0m, Currency.USD);

            Assert.That(sum, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ThreePlusFive_EqualsEight()
        {
            Money money1 = new Money(3.0m, Currency.USD);
            Money money2 = new Money(5.0m, Currency.USD);

            Money sum = money1.add(money2);

            Money expectedResult = new Money(8.0m, Currency.USD);

            Assert.That(sum, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ThreeUsdPlusFiveCad_ReturnsSumInCad_Stub()
        {
            Money money1 = new Money(3.0m, Currency.USD);
            Money money2 = new Money(5.0m, Currency.CAD);

            money1.SetExchangeService(new ExchangeServiceStub());
            Money sum = money1.add(money2);

            Money expectedResult = new Money(11m, Currency.CAD);

            Assert.That(sum, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ThreeUsdPlusFiveCad_ReturnsSumInCad_Mock()
        {
            Mock<CurrencyConverting> mockService = new Mock<CurrencyConverting>();
            mockService.Setup(s => s.convert(3.0m, Currency.USD, Currency.CAD)).Returns(6.0m);

            Money money1 = new Money(3.0m, Currency.USD);
            Money money2 = new Money(5.0m, Currency.CAD);

            money1.SetExchangeService(mockService.Object);
            Money sum = money1.add(money2);

            Money expectedResult = new Money(11m, Currency.CAD);

            Assert.That(sum, Is.EqualTo(expectedResult));
        }
    }
}
