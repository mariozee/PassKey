using PassKey.Data;
using PassKey.Exceptions;
using PassKey.SecurityUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.UsersInputValidators
{
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
                throw new InvalidPasswordException(GlobalMessages.IncorectPassword);
            }
        }
    }
}
