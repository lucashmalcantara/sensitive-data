using LucasAlcantara.SensitiveData.Obfuscation.Constants;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;
using System.Linq;
using System.Text;

namespace LucasAlcantara.SensitiveData.Obfuscation.Strategies
{
    public class NameObfuscationStrategy : IObfuscationStrategy
    {
        public string Obfuscate(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            const char separatorCharacter = ' ';

            var separatedTerms = value.Split(separatorCharacter);

            var ofuscatedValue = new StringBuilder(separatedTerms.First());

            var quantityOfTerms = separatedTerms.Length;

            for (int i = 1; i < quantityOfTerms; i++)
            {
                var obfuscatedPart = new string(ObfuscationConstants.DefaultCharForStringValues, separatedTerms[i].Length);
                ofuscatedValue.Append(separatorCharacter);
                ofuscatedValue.Append(obfuscatedPart);
            }

            return ofuscatedValue.ToString();
        }

    }
}
