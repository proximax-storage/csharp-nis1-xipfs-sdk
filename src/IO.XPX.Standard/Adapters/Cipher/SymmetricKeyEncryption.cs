using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Adapters.Cipher
{
    abstract class SymmetricKeyEncryption : CustomEncryption
    {

        public abstract byte[] encrypt(byte[] data, char[] key);
        public abstract byte[] decrypt(byte[] data, char[] key);

    }
}
