using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
