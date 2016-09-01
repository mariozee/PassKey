namespace PassKey.Exceptions
{
    public class UsernameAlreadyUsedException : PassKeyException
    {
        public UsernameAlreadyUsedException(string message)
            : base(message)
        {
        }
    }
}