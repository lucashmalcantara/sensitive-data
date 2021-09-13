using LucasAlcantara.SensitiveData.Obfuscation.Enums;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;

namespace LucasAlcantara.SensitiveData.Obfuscation.Factories.Interfaces
{
    public interface IObfuscationFactory
    {
        IObfuscationStrategy GetStrategy(ObfuscationType obfuscationType);
    }
}
