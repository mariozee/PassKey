using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.Exceptions
{
    public class UsernameAlreadyUsedException : PassKeyException
    {
        public UsernameAlreadyUsedException(string message)
            : base(message)
        {
        }
    }
}
