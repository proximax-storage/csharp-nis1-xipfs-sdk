using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface NameStep<T>
    {
        T name(string name);
    }
}
