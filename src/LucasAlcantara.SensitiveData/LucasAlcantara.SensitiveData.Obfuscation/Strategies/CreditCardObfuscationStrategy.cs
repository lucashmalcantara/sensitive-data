using LucasAlcantara.SensitiveData.Obfuscation.Constants;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;

namespace LucasAlcantara.SensitiveData.Obfuscation.Strategies
{
    public class CreditCardObfuscationStrategy : IObfuscationStrategy
    {
        public string Obfuscate(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            const int nonOfuscatedCharactersLength = 4;

            var hasTheNecessaryLength = value.Length > nonOfuscatedCharactersLength;

            if (!hasTheNecessaryLength)
            {
                var completeOfuscatedValue = new string(ObfuscationConstants.DefaultCharForStringValues, value.Length);
                return completeOfuscatedValue;
            }

            var obfuscatedCharactersLength = value.Length - nonOfuscatedCharactersLength;
            var startIndexOfTheNonOfuscatedPart = value.Length - nonOfuscatedCharactersLength;

            var ofuscatedCharacters = new string(ObfuscationConstants.DefaultCharForStringValues, obfuscatedCharactersLength);
            var nonOfuscatedCharacters = value.Substring(startIndexOfTheNonOfuscatedPart);

            var obfuscatedValue = ofuscatedCharacters + nonOfuscatedCharacters;

            return obfuscatedValue;
        }
    }
}
