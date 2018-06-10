using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Strategy.Privacy
{
    public sealed class SecuredWithNemKeysPrivacyStrategy : AbstractSecureMessagePrivacyStrategy
    {
        public SecuredWithNemKeysPrivacyStrategy(string privateKey, string publicKey)
        {
            base(privateKey, publicKey);
        }
    }
}
