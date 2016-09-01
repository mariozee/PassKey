namespace PassKey.UsersInputValidators
{
    using System.Linq;
    using Data;
    using Exceptions;
    using SecurityUtilities;

    public class LoginValidator
    {
        public void ValidateInput(string username, string password)
        {
            if (!RegistryData.GetUsernames().Contains(username))
            {
                throw new InvalidUsernameException(GlobalMessages.NonExistingUser);
            }

            string hashedPassword = RegistryData.GetUserPassword(username);
            string currentPasswordHash = HashUtilities.HashPassword(password);
            if (hashedPassword != currentPasswordHash)
            {
                throw new InvalidPasswordLenghtException(GlobalMessages.IncorectPassword);
            }
        }
    }
}