namespace PassKey.Exceptions
{
    public class InvalidPasswordLenghtException : PassKeyException
    {
        public InvalidPasswordLenghtException(string message)
            : base(message)
        {
        }
    }
}