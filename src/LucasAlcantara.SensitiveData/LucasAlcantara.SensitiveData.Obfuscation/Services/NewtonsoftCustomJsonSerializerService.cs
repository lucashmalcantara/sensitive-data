using LucasAlcantara.SensitiveData.Obfuscation.Services.Interfaces;
using Newtonsoft.Json;

namespace LucasAlcantara.SensitiveData.Obfuscation.Services
{
    public class NewtonsoftCustomJsonSerializerService : ICustomJsonSerializerService
    {
        public string Serialize(object objectToBeSerialized) => JsonConvert.SerializeObject(objectToBeSerialized);
    }
}
