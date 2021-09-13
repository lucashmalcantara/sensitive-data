using LucasAlcantara.SensitiveData.Obfuscation.Constants;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;

namespace LucasAlcantara.SensitiveData.Obfuscation.Strategies
{
    public class CompleteObfuscationStrategy : IObfuscationStrategy
    {
        public string Obfuscate(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            var completeOfuscatedValue = new string(ObfuscationConstants.DefaultCharForStringValues, value.Length);

            return completeOfuscatedValue;
        }
    }
}
