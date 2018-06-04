using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Exceptions
{
    class EncryptionFailureException : Exception
    {
        public EncryptionFailureException(string message)
        {
            throw new Exception(message);
        }
    }
}
