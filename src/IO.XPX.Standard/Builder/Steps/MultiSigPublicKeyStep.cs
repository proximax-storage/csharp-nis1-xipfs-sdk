using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface MultiSigPublicKeyStep<T>
    {
        T multisigPublicKeyStep(string multisigPublicKeyStep);
    }
}
