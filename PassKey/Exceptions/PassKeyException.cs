using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.Exceptions
{
    public class PassKeyException : Exception
    {
        public PassKeyException(string message)
            : base(message)
        {
        }
    }
}
