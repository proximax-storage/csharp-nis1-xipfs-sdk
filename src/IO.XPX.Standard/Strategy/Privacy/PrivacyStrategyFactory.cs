using System;
using System.Collections.Generic;
using System.Text;
using IO.XPX.Standard.Adapters.Cipher;

namespace IO.XPX.Standard.Strategy.Privacy
{
    public class PrivacyStrategyFactory
    {
        public static PrivacyStrategy plainPrivacyStrategy;

        private PrivacyStrategyFactory() { }

        public static PrivacyStrategy plainPrivacy()
        {
            if (plainPrivacyStrategy == null)
                plainPrivacyStrategy = new PlainPrivacyStrategy();

            return plainPrivacyStrategy;
        }

        public static PrivacyStrategy securedWithNemKeysPrivacyStrategy(string senderOrReceiverPrivateKey, string receiverOrSenderPublicKey)
        {
            return new SecuredWithNemKeysPrivacyStrategy(senderOrReceiverPrivateKey, receiverOrSenderPublicKey);
        }

        public static PrivacyStrategy securedWithPasswordPrivacyStrategy(string password)
        {
            return new SecuredWithPasswordPrivacyStrategy(new BinaryPBKDF2CipherEncryption(), password);
        }
    }
}
