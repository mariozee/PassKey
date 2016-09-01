namespace PassKey.ActionHandlers
{
    using Data;
    using SecurityUtilities;

    public class RegistrationHandler
    {
        public void Register(string username, string password)
        {
            string hashedPass = HashUtilities.HashPassword(password);
            byte[] key = HashUtilities.HashKey(password);
            string encryptedData = CryptographicUtilities.Encrypt(string.Empty, key);

            RegistryData.CreateUser(username, hashedPass, encryptedData);
        }
    }
}
