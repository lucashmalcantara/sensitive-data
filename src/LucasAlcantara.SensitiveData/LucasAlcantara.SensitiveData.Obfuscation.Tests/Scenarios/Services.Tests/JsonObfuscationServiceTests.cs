using FluentAssertions;
using LucasAlcantara.SensitiveData.Obfuscation.Services;
using LucasAlcantara.SensitiveData.Obfuscation.Tests.Support.CustomerContext.Models;
using System.Collections.Generic;
using Xunit;

namespace LucasAlcantara.SensitiveData.Obfuscation.Tests.Scenarios.Services.Tests
{
    public class JsonObfuscationServiceTests
    {
        [Fact]
        public void GetObfuscatedJson_should_return_a_JSON_with_ofuscated_properties()
        {
            // Arrange
            var contact1 = new Contact("Chris M. Bell", "+5531999999999");
            var contact2 = new Contact("June H. Navarro", "+55 (31) 99999-9998");
            var contacts = new List<Contact>() { contact1, contact2 };

            var customer = new CustomerModel(
                "Lucas Alcântara",
                "lucas@test.com.br",
                "Rua Xxxx, 9999 - Centro - Belo Horizonte - MG",
                "Software Developer",
                contacts);

            var obfuscationService = new JsonObfuscationService();

            const string expectedJson = @"{""name"":""Lucas *********"",""email"":""*****@test.com.br"",""address"":""Rua ****, **** - ****** - **** ********* - **"",""jobTitle"":""Software Developer"",""contacts"":[{""name"":""Chris *. ****"",""phone"":""+5531999999999""},{""name"":""June H. Navarro"",""phone"":""*** (**) *****-****""}]}";

            // Act
            var ofuscatedJson = obfuscationService.GetObfuscatedJson(customer);

            // Assert
            ofuscatedJson.Should().Be(expectedJson);
        }

        [Fact]
        public void GetObfuscatedJson_should_return_a_JSON_with_ofuscated_properties_using_a_different_ICustomJsonSerializerService()
        {
            // Arrange
            var contact1 = new Contact("Chris M. Bell", "+5531999999999");
            var contact2 = new Contact("June H. Navarro", "+55 (31) 99999-9998");
            var contacts = new List<Contact>() { contact1, contact2 };

            var customer = new CustomerModel(
                "Lucas Alcântara",
                "lucas@test.com.br",
                "Rua Xxxx, 9999 - Centro - Belo Horizonte - MG",
                "Software Developer",
                contacts);

            var newtonsoftCustomJsonSerializerService = new NewtonsoftCustomJsonSerializerService();
            var obfuscationService = new JsonObfuscationService(newtonsoftCustomJsonSerializerService);

            const string expectedJson = @"{""name"":""Lucas *********"",""email"":""*****@test.com.br"",""address"":""Rua ****, **** - ****** - **** ********* - **"",""jobTitle"":""Software Developer"",""contacts"":[{""name"":""Chris *. ****"",""phone"":""+5531999999999""},{""name"":""June H. Navarro"",""phone"":""*** (**) *****-****""}]}";

            // Act
            var ofuscatedJson = obfuscationService.GetObfuscatedJson(customer);

            // Assert
            ofuscatedJson.Should().Be(expectedJson);
        }
    }
}
