namespace LucasAlcantara.SensitiveData.Obfuscation.Services.Interfaces
{
    public interface ICustomJsonSerializerService
    {
        string Serialize(object objectToBeSerialized);
    }
}
