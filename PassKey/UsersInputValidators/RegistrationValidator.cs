using PassKey.Data;
using PassKey.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PassKey.UsersInputValidators
{
    public class RegistrationValidator
    {
        public void ValidateInput(string username, string password, string confirmedPassword)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                username.Length < Constants.MinUsernameLenght ||
                username.Length > Constants.MaxUsernameLenght)
            {
                throw new InvalidUsernameException(string.Format(GlobalMessages.InvalidUsernameLenght
                    , Constants.MinUsernameLenght
                    , Constants.MaxUsernameLenght));
            }

            if (!Regex.IsMatch(username, Constants.UsernameValidationPattern))
            {
                throw new InvalidUsernameException(GlobalMessages.InvalidUsername);
            }

            //if (RegistryData.GetUsernames().Contains(username))
            //{
            //    throw new InvalidUsernameException(GlobalMessages.AlreadyTaken);
            //}

            if (password != confirmedPassword)
            {
                throw new InvalidPasswordException(GlobalMessages.PasswordsMismatch);
            }

            if (string.IsNullOrWhiteSpace(password) ||
                password.Length < Constants.MinPasswordLenght)
            {
                throw new InvalidPasswordException(string.Format(GlobalMessages.InvalidPasswordLenght
                    , Constants.MinPasswordLenght
                    , Constants.MaxPasswordLenght));

            }
        }
    }
}
