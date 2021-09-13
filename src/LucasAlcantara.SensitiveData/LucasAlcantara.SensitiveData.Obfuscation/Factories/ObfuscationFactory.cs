using LucasAlcantara.SensitiveData.Obfuscation.Enums;
using LucasAlcantara.SensitiveData.Obfuscation.Factories.Interfaces;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;

namespace LucasAlcantara.SensitiveData.Obfuscation.Factories
{
    public class ObfuscationFactory : IObfuscationFactory
    {
        public IObfuscationStrategy GetStrategy(ObfuscationType obfuscationType)
        {
            throw new System.NotImplementedException();
        }
    }
}
