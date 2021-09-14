using LucasAlcantara.SensitiveData.Obfuscation.Constants;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;

namespace LucasAlcantara.SensitiveData.Obfuscation.Strategies
{
    public class HalfObfuscationStrategy : IObfuscationStrategy
    {
        public string Obfuscate(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            int middleIndex = value.Length / 2;

            var ofuscatedValue =
                new string(ObfuscationConstants.DefaultCharForStringValues, middleIndex) +
                value.Substring(middleIndex);

            return ofuscatedValue;
        }
    }
}
