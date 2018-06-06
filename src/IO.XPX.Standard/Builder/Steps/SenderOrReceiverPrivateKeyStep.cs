using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface SenderOrReceiverPrivateKeyStep<T>
    {
        T senderOrReceiverPrivateKey(string senderOrReceiverPrivateKey);
    }
}
