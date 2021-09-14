using FluentAssertions;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies;
using Xunit;

namespace LucasAlcantara.SensitiveData.Obfuscation.Tests.Scenarios.Strategies.Tests
{
    public class NameObfuscationStrategyTests
    {
        [Fact]
        public void Obfuscate_should_return_null_when_the_given_value_is_null()
        {
            // Arrange
            const string value = null;
            var obfuscationStrategy = new NameObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().BeNull();
        }

        [Fact]
        public void Obfuscate_should_return_an_empty_string_when_the_given_value_is_empty()
        {
            // Arrange
            var obfuscationStrategy = new NameObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(string.Empty);

            // Assert
            obfuscatedValue.Should().BeEmpty();
        }

        [Theory]
        [InlineData("Betty J. Jones", "Betty ** *****")]
        [InlineData("Phillip O'Conner", "Phillip ********")]
        [InlineData("Molly Harriman", "Molly ********")]
        [InlineData("Letícia Ferreira Martins", "Letícia ******** *******")]
        [InlineData("Daniel Martins Cavalcanti da Silva", "Daniel ******* ********** ** *****")]
        public void Obfuscate_should_not_obfuscate_the_first_name(string value, string expectedValue)
        {
            // Arrange
            var obfuscationStrategy = new NameObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().Be(expectedValue);
        }
    }
}
