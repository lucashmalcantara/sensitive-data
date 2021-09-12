using LucasAlcantara.SensitiveData.Obfuscation.Services.Interfaces;
using System.Text.Json;

namespace LucasAlcantara.SensitiveData.Obfuscation.Services
{
    public class DefaultCustomJsonSerializerService : ICustomJsonSerializerService
    {
        public string Serialize(object objectToBeSerialized) => JsonSerializer.Serialize(objectToBeSerialized);
    }
}
