namespace PassKey.Exceptions
{
    public class InvalidUsernameException : PassKeyException
    {
        public InvalidUsernameException(string message)
            : base(message)
        {
        }
    }
}