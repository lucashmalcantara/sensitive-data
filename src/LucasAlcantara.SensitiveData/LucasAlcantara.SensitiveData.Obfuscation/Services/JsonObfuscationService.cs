using LucasAlcantara.SensitiveData.Obfuscation.Attributes;
using LucasAlcantara.SensitiveData.Obfuscation.Services.Interfaces;
using System;
using System.Linq;

namespace LucasAlcantara.SensitiveData.Obfuscation.Services
{
    public class JsonObfuscationService : IJsonObfuscationService
    {
        private readonly ICustomJsonSerializerService _customJsonSerializerService;

        public JsonObfuscationService()
        {
            _customJsonSerializerService = new DefaultCustomJsonSerializerService();
        }

        public JsonObfuscationService(ICustomJsonSerializerService customJsonSerializerService)
        {
            _customJsonSerializerService = customJsonSerializerService;
        }

        public string GetObfuscatedJson(object objectToBeOfuscated)
        {
            var obfuscatedJson = _customJsonSerializerService.Serialize(objectToBeOfuscated);

            var properties = objectToBeOfuscated.GetType().GetProperties();

            foreach (var propertie in properties)
            {
                var obfuscateAttributes = (ObfuscateAttribute[])propertie.GetCustomAttributes(typeof(ObfuscateAttribute), true);

                var isEmpty = !obfuscateAttributes.Any();

                if (isEmpty)
                    continue;

                throw new NotImplementedException();

            }

            return obfuscatedJson;
        }
    }
}
