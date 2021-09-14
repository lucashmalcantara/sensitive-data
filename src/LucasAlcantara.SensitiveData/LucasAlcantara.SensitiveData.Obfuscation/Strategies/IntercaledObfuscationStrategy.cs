using LucasAlcantara.SensitiveData.Obfuscation.Constants;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;
using System.Linq;
using System.Text;

namespace LucasAlcantara.SensitiveData.Obfuscation.Strategies
{
    public class IntercaledObfuscationStrategy : IObfuscationStrategy
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
                bool mustOfuscate = i % 2 == 1;

                var part = mustOfuscate ? GetOfuscatedPart(separatedTerms[i]) : separatedTerms[i];
                
                ofuscatedValue.Append(separatorCharacter);
                ofuscatedValue.Append(part);
            }

            return ofuscatedValue.ToString();
        }

        private string GetOfuscatedPart(string part) => 
            new string(ObfuscationConstants.DefaultCharForStringValues, part.Length);
    }
}
