using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;

namespace LucasAlcantara.SensitiveData.Obfuscation.Strategies
{
    public class NoneObfuscationStrategy : IObfuscationStrategy
    {
        public string Obfuscate(string value) => value;
    }
}
