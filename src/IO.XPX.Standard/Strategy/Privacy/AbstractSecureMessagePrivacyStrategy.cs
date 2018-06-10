using System;
using System.Collections.Generic;
using System.Text;
using CSharp2nem.Model.AccountSetup;
using IO.XPX.Standard.Models;

namespace IO.XPX.Standard.Strategy.Privacy
{
    abstract class AbstractSecureMessagePrivacyStrategy : PrivacyStrategy
    {
        public readonly KeyValuePair keyPairOfPrivateKey;
        public readonly KeyValuePair keyPairOfPublicKey;
        public readonly Account accountWithPrivateKey;
        public readonly Account aacountWithPublicKey;

        public AbstractPlainMessagePrivacyStrategy(string privateKey, string publicKey)
        {
            if (privateKey == null)
                throw new ArgumentNullException("Private Key", "private key is required");

            if (publicKey == null)
                throw new ArgumentNullException("Public Key", "public key is required");
        }

        public override NemMessageType.eNemMessageType GetNemMessageType()
        {
            return NemMessageType.eNemMessageType.SECURE;
        }

        public override byte[] decodeTransaction()
        {
           
        }

    }
}
