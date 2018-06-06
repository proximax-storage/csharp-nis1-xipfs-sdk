using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface PathStep<T>
    {
        T path(string path);
    }
}
