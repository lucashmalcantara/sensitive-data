namespace LucasAlcantara.SensitiveData.Obfuscation.Services.Interfaces
{
    public interface IJsonObfuscationService
    {
        /// <summary>
        /// Returns a ofuscated JSON.
        /// <para>Note: This methoed will not modify any value of the original object.</para>
        /// </summary>
        /// <param name="data">Object to be serialized and ofuscated.</param>
        /// <returns>Ofuscated JSON.</returns>
        string GetObfuscatedJson(object objectToBeOfuscated);
    }
}
