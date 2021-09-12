using LucasAlcantara.SensitiveData.Obfuscation.Attributes;
using LucasAlcantara.SensitiveData.Obfuscation.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LucasAlcantara.SensitiveData.Obfuscation.Tests.Support.CustomerContext.Models
{
    public class CustomerModel
    {
        [Obfuscate(ObfuscationType.Name)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get;  set; }

        [Obfuscate(ObfuscationType.Email)]
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [Obfuscate(ObfuscationType.Address)]
        [JsonProperty("address")]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonProperty("jobTitle")]
        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("contacts")]
        [JsonPropertyName("contacts")]
        public IList<Contact> Contacts { get; set; }

        public CustomerModel(string name, string email, string address, string jobTitle, IList<Contact> contacts)
        {
            Name = name;
            Email = email;
            Address = address;
            JobTitle = jobTitle;
            Contacts = contacts;
        }
    }
}
