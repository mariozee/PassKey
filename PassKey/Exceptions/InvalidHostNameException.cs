using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
