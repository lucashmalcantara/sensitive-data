using FluentAssertions;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies;
using Xunit;

namespace LucasAlcantara.SensitiveData.Obfuscation.Tests.Scenarios.Strategies.Tests
{
    public class EmailObfuscationStrategyTests
    {
        [Fact]
        public void Obfuscate_should_return_null_when_the_given_value_is_null()
        {
            // Arrange
            const string value = null;
            var obfuscationStrategy = new EmailObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().BeNull();
        }

        [Fact]
        public void Obfuscate_should_return_an_empty_string_when_the_given_value_is_empty()
        {
            // Arrange
            var obfuscationStrategy = new EmailObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(string.Empty);

            // Assert
            obfuscatedValue.Should().BeEmpty();
        }

        [Theory]
        [InlineData("lucas@test.com.br", "*****@test.com.br")]
        [InlineData("lucas@test.com", "*****@test.com")]
        [InlineData("lucas.alcantara@abcd.com", "***************@abcd.com")]
        public void Obfuscate_should_return_a_obfuscated_text_up_to_the_at_sign(string value, string expectedValue)
        {
            // Arrange
            var obfuscationStrategy = new EmailObfuscationStrategy();

            // Act
            var obfuscatedValue = obfuscationStrategy.Obfuscate(value);

            // Assert
            obfuscatedValue.Should().Be(expectedValue);
        }
    }
}
