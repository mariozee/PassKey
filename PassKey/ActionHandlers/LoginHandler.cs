using PassKey.Data;
using PassKey.SecurityUtilities;
using PassKey.UserInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.ActionHandlers
{
    public class LoginHandler
    {
        private LoggedUser user;

        public LoginHandler()
        {
        }

        public LoggedUser Login(string username, string password)
        {
            byte[] key = HashUtilities.HashKey(password);                      
            var data = DataTranslator.Parse(username, key);
            this.user = new LoggedUser(username, key, data);

            return this.user;
        }
    }
}
