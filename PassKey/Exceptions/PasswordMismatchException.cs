using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
