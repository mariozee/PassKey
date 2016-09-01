namespace PassKey.Exceptions
{
    public class InvalidNameLenghtException : PassKeyException
    {
        public InvalidNameLenghtException(string message)
            : base(message)
        {
        }
    }
}