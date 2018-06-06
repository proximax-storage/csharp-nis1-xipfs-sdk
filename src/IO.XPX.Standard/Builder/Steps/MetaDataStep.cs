using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface MetaDataStep<T>
    {
        T metadata(Dictionary<string, string> metadata);
    }
}
