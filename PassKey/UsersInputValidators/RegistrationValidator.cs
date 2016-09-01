namespace PassKey.UsersInputValidators
{    
    using System.Linq;
    using System.Text.RegularExpressions;
    using Data;
    using Exceptions;

    public class RegistrationValidator
    {
        public void ValidateInput(string username, string password, string confirmedPassword)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                username.Length < Constants.MinUsernameLenght ||
                username.Length > Constants.MaxUsernameLenght)
            {
                throw new InvalidNameLenghtException(string.Format(GlobalMessages.InvalidUsernameLenght
                    , Constants.MinUsernameLenght
                    , Constants.MaxUsernameLenght));
            }

            if (!Regex.IsMatch(username, Constants.UsernameValidationPattern))
            {
                throw new InvalidUsernameException(GlobalMessages.InvalidUsername);
            }

            if (RegistryData.GetUsernames().Contains(username))
            {
                throw new UsernameAlreadyUsedException(GlobalMessages.AlreadyTaken);
            }

            if (password != confirmedPassword)
            {
                throw new PasswordMismatchException(GlobalMessages.PasswordsMismatch);
            }

            if (string.IsNullOrWhiteSpace(password) ||
                password.Length < Constants.MinPasswordLenght)
            {
                throw new InvalidPasswordLenghtException(string.Format(GlobalMessages.InvalidPasswordLenght
                    , Constants.MinPasswordLenght
                    , Constants.MaxPasswordLenght));

            }
        }
    }
}