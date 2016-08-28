using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.Exceptions
{
    public class InvalidPasswordException : PassKeyException
    {
        public InvalidPasswordException(string message)
            : base(message)
        {
        }
    }
}
