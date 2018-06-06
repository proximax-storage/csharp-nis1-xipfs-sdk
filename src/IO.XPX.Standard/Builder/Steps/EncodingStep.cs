using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface EncodingStep<T>
    {
        T encoding(string encoding);
    }
}
