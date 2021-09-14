using LucasAlcantara.SensitiveData.Obfuscation.Enums;
using LucasAlcantara.SensitiveData.Obfuscation.Factories.Interfaces;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies;
using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;

namespace LucasAlcantara.SensitiveData.Obfuscation.Factories
{
    public class ObfuscationFactory : IObfuscationFactory
    {
        public IObfuscationStrategy GetStrategy(ObfuscationType obfuscationType) => obfuscationType switch
        {
            ObfuscationType.None => new NoneObfuscationStrategy(),
            ObfuscationType.Half => new HalfObfuscationStrategy(),
            ObfuscationType.Complete => new CompleteObfuscationStrategy(),
            ObfuscationType.Intercaled => new IntercaledObfuscationStrategy(),
            ObfuscationType.Name => new NameObfuscationStrategy(),
            ObfuscationType.Email => new EmailObfuscationStrategy(),
            ObfuscationType.Phone => new HalfObfuscationStrategy(),
            ObfuscationType.Address => new IntercaledObfuscationStrategy(),
            ObfuscationType.CreditCard => new CreditCardObfuscationStrategy(),
            _ => new CompleteObfuscationStrategy()
        };
    }
}
