using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Builder.Steps
{
    interface FileNameStep<T>
    {
        T fileName(string fileName);
    }
}
