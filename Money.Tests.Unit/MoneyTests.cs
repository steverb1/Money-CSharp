﻿using NUnit.Framework;
using System;
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
        public void ThreeUsdPlusFiveCad_ReturnsSumInCad()
        {
            Money money1 = new Money(3.0m, Currency.USD);
            Money money2 = new Money(5.0m, Currency.CAD);

            money1.SetExchangeService(new ExchangeServiceStub());
            Money sum = money1.add(money2);

            Money expectedResult = new Money(11m, Currency.CAD);

            Assert.That(sum, Is.EqualTo(expectedResult));
        }
    }
}
