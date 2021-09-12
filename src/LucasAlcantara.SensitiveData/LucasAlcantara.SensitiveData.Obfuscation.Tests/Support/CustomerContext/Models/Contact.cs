using LucasAlcantara.SensitiveData.Obfuscation.Attributes;
using LucasAlcantara.SensitiveData.Obfuscation.Enums;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace LucasAlcantara.SensitiveData.Obfuscation.Tests.Support.CustomerContext.Models
{
    public struct Contact
    {
        [Obfuscate(ObfuscationType.Name)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; }

        [Obfuscate(ObfuscationType.Phone)]
        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone { get; }

        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
