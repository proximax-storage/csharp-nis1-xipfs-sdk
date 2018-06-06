using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface ReceiverOrSenderPublicKeyStep<T>
    {
        T receiverOrSenderPublicKey(string receiverOrSenderPublicKey);
    }
}
