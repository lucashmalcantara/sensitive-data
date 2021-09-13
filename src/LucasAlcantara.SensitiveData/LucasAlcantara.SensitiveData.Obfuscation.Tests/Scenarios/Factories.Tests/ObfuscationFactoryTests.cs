using FluentAssertions;
using LucasAlcantara.SensitiveData.Obfuscation.Enums;
using LucasAlcantara.SensitiveData.Obfuscation.Factories;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies;
using System;
using System.Collections.Generic;
using Xunit;

namespace LucasAlcantara.SensitiveData.Obfuscation.Tests.Scenarios.FactoriesTests
{
    public class ObfuscationFactoryTests
    {
        [Theory, MemberData(nameof(ObfuscationTypeInstances))]
        public void GetStrategy_should_return_an_instance_of_IObfuscationStrategy_according_to_the_given_ObfuscationType(
           ObfuscationType obfuscationType, Type expectedInstanceType)
        {
            // Arrage
            var obfuscationFactory = new ObfuscationFactory();

            // Act
            var strategy = obfuscationFactory.GetStrategy(obfuscationType);

            // Assert
            strategy.Should().BeOfType(expectedInstanceType).And.NotBeNull();
        }

        public static IEnumerable<object[]> ObfuscationTypeInstances =>
            new List<object[]>
            {
                new object[] { ObfuscationType.None, typeof(NoneObfuscationStrategy) },
                new object[] { ObfuscationType.Half, typeof(HalfObfuscationStrategy) },
                new object[] { ObfuscationType.Complete, typeof(CompleteObfuscationStrategy) },
                new object[] { ObfuscationType.Intercaled, typeof(IntercaledObfuscationStrategy) },
                new object[] { ObfuscationType.Name, typeof(NameObfuscationStrategy) },
                new object[] { ObfuscationType.Email, typeof(EmailObfuscationStrategy) },
                new object[] { ObfuscationType.Phone, typeof(HalfObfuscationStrategy) },
                new object[] { ObfuscationType.Address, typeof(IntercaledObfuscationStrategy) },
                new object[] { ObfuscationType.CreditCard, typeof(CreditCardObfuscationStrategy) }
            };
    }
}
