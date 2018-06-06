using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface ContentTypeStep<T>
    {
        T contentType(string contentType);
    }
}
