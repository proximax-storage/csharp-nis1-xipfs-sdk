using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace IO.XPX.Standard.Adapters.Cipher
{
    class BinaryPBKDF2CipherEncryption : SymmetricKeyEncryption
    {
        private static readonly string CONST_ALGO_PBKDF2 = "PBKDF2WithHmacSHA256";

        private static readonly byte[] SALT
         = 
          {
             0xA9,
             0x98,
             0xC8,
             0x32,
             0x56,
             0x35,
             0xE3,
             0x03
           };

        private static readonly byte[] FIXED_NONCE
        =
        {
             0xA9,
             0x98,
             0xC8,
             0x32,
             0x56,
             0x35,
             0xE3,
             0x03
        };

        public byte[] encrypt(byte[] binary, char[] password)
        {

        }

    }
}
