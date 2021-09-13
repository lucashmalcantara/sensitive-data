using LucasAlcantara.SensitiveData.Obfuscation.Strategies.Interfaces;
using System;

namespace LucasAlcantara.SensitiveData.Obfuscation.Strategies
{
    public class NoneObfuscationStrategy : IObfuscationStrategy
    {
        public string Obfuscate(string value)
        {
            throw new NotImplementedException();
        }
    }
}
