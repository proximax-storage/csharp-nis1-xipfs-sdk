using System;
using System.Collections.Generic;
using System.Text;
using IO.XPX.Standard.Strategy.Privacy;

namespace IO.XPX.Standard.Builder.Steps
{
    interface PrivacyStrategyDownloadStep<T>
    {
        T privacyStrategy(PrivacyStrategy privacyStrategy);

        T plainPrivacy();

        T securedWithNemKeysPrivacyStrategy(string senderOrReceiverPrivateKey, string receiverOrSenderPublicKey);

        T securedWithPasswordPrivacyStrategy(string password);
    }
}
