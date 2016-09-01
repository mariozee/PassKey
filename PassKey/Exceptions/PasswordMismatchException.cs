namespace PassKey.Exceptions
{
    public class PasswordMismatchException : PassKeyException
    {
        public PasswordMismatchException(string message)
            : base(message)
        {
        }
    }
}