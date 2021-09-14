using FluentAssertions;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies;
using Xunit;

namespace LucasAlcantara.SensitiveData.Obfuscation.Tests.Scenarios.Strategies.Tests
{
    public class NoneObfuscationStrategyTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("Lucas Alcântara", "Lucas Alcântara")]
        [InlineData("lucas@test.com.br", "lucas@test.com.br")]
        [InlineData("Lorem", "Lorem")]
        [InlineData("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.")]
        public void Obfuscate_should_exactly_the_same_value(string value, string expectedValue)
        {
            // Arrange
            var obfuscationStrategy = new NoneObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().Be(expectedValue);
        }
    }
}
