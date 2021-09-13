using FluentAssertions;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies;
using Xunit;

namespace LucasAlcantara.SensitiveData.Obfuscation.Tests.Scenarios.Strategies.Tests
{
    public class CreditCardObfuscationStrategyTests
    {
        [Fact]
        public void Obfuscate_should_return_null_when_the_given_value_is_null()
        {
            // Arrange
            const string value = null;
            var obfuscationStrategy = new CreditCardObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().BeNull();
        }

        [Fact]
        public void Obfuscate_should_return_an_empty_string_when_the_given_value_is_empty()
        {
            // Arrange
            var obfuscationStrategy = new CreditCardObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(string.Empty);

            // Assert
            obfuscatedValue.Should().BeEmpty();
        }

        [Theory]
        [InlineData("5336 1600 0389 3456", "***************3456")]
        [InlineData("5336160003893456", "************3456")]
        public void Obfuscate_should_ofuscate_the_value_except_the_last_four_digits(string value, string expectedValue)
        {
            // Arrange
            var obfuscationStrategy = new CreditCardObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData("5336", "****")]
        [InlineData("5", "*")]
        public void Obfuscate_should_return_a_complete_ofuscated_string_when_the_length_is_less_then_or_equals_to_four(string value, string expectedValue)
        {
            // Arrange
            var obfuscationStrategy = new CreditCardObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().Be(expectedValue);
        }
    }
}
