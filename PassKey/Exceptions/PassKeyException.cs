namespace PassKey.Exceptions
{
    using System;

    public class PassKeyException : Exception
    {
        public PassKeyException(string message)
            : base(message)
        {
        }
    }
}