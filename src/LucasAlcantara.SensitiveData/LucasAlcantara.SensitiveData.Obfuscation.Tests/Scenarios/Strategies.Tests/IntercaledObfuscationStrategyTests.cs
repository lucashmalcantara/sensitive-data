using FluentAssertions;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies;
using Xunit;

namespace LucasAlcantara.SensitiveData.Obfuscation.Tests.Scenarios.Strategies.Tests
{
    public class IntercaledObfuscationStrategyTests
    {
        [Fact]
        public void Obfuscate_should_return_null_when_the_given_value_is_null()
        {
            // Arrange
            const string value = null;
            var obfuscationStrategy = new IntercaledObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().BeNull();
        }

        [Fact]
        public void Obfuscate_should_return_an_empty_string_when_the_given_value_is_empty()
        {
            // Arrange
            var obfuscationStrategy = new IntercaledObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(string.Empty);

            // Assert
            obfuscatedValue.Should().BeEmpty();
        }

        [Theory]
        [InlineData("Some Text", "Some ****")]
        [InlineData("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Lorem ***** dolor *** amet, *********** adipiscing *****")]
        [InlineData("Some text with space in the end ", "Some **** with ***** in *** end ")]
        [InlineData(" Some text with space at the beginning", " **** text **** space ** the *********")]
        [InlineData(" Some text with space on both sides ", " **** text **** space ** both ***** ")]
        public void Obfuscate_should_return_an_alternately_obfuscated_text_considering_space_as_separator(string value, string expectedValue)
        {
            // Arrange
            var obfuscationStrategy = new IntercaledObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().Be(expectedValue);
        }
    }
}
