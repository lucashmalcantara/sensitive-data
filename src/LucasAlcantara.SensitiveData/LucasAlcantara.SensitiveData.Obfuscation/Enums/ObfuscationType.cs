namespace LucasAlcantara.SensitiveData.Obfuscation.Enums
{
    public enum ObfuscationType
    {
        None = 0,
        Half = 1,
        Complete = 2,
        Intercaled = 3, //TODO Pattern: [\D\W] OR 
        Name = 4,
        Email = 5,
        Phone = 6,
        Address = 7,
        CreditCard = 8
    }
}
