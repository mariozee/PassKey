namespace PassKey.ActionHandlers
{
    using PassKey.Data;
    using PassKey.SecurityUtilities;
    using PassKey.UserInfo;

    public class LoginHandler
    {
        private LoggedUser user;

        public LoggedUser Login(string username, string password)
        {
            byte[] key = HashUtilities.HashKey(password);                      
            var data = DataTranslator.Parse(username, key);
            this.user = new LoggedUser(username, key, data);

            return this.user;
        }
    }
}
