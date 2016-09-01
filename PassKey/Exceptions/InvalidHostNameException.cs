namespace PassKey.Exceptions
{
    public class InvalidHostNameException : PassKeyException
    {
        public InvalidHostNameException(string message)
            : base(message)
        {
        }
    }
}