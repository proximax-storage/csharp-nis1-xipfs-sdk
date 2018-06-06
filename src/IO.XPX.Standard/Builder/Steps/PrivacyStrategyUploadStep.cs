using System;
using System.Collections.Generic;
using System.Text;
using IO.XPX.Standard.Strategy.Privacy;

namespace IO.XPX.Standard.Builder.Steps
{
    interface PrivacyStrategyUploadStep<T>
    {
        T privacyStrategy(PrivacyStrategy privacyStrategy);

        T plainPrivacy();

        T securedWithNemKeyPrivacyStrategy();

        T securedWithPasswordPrivacyStrategy(string password);
    }
}
