using FluentAssertions;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies;
using Xunit;

namespace LucasAlcantara.SensitiveData.Obfuscation.Tests.Scenarios.Strategies.Tests
{
    public class HalfObfuscationStrategyTests
    {
        [Fact]
        public void Obfuscate_should_return_null_when_the_given_value_is_null()
        {
            // Arrange
            const string value = null;
            var obfuscationStrategy = new HalfObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().BeNull();
        }

        [Fact]
        public void Obfuscate_should_return_an_empty_string_when_the_given_value_is_empty()
        {
            // Arrange
            var obfuscationStrategy = new HalfObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(string.Empty);

            // Assert
            obfuscatedValue.Should().BeEmpty();
        }

        [Theory]
        [InlineData("Some Text", "**** Text")]
        [InlineData("Lorem", "**rem")]
        [InlineData("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "****************************consectetur adipiscing elit.")]
        public void Obfuscate_should_return_a_half_obfuscated_text(string value, string expectedValue)
        {
            // Arrange
            var obfuscationStrategy = new HalfObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().Be(expectedValue);
        }
    }
}
