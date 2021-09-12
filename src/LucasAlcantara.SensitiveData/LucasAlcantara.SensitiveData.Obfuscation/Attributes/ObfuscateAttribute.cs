using LucasAlcantara.SensitiveData.Obfuscation.Enums;
using System;

namespace LucasAlcantara.SensitiveData.Obfuscation.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class ObfuscateAttribute : Attribute
    {
        public ObfuscationType ObfuscationType { get; }

        public ObfuscateAttribute(ObfuscationType obfuscationType)
        {
            ObfuscationType = obfuscationType;
        }
    }
}
