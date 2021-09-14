using LucasAlcantara.SensitiveData.Obfuscation.Constants;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;

namespace LucasAlcantara.SensitiveData.Obfuscation.Strategies
{
    public class EmailObfuscationStrategy : IObfuscationStrategy
    {
        public string Obfuscate(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            int indexOfAtSign = value.IndexOf("@");

            var ofuscatedValue = 
                new string(ObfuscationConstants.DefaultCharForStringValues, indexOfAtSign) +
                value.Substring(indexOfAtSign);

            return ofuscatedValue;
        }
    }
}
